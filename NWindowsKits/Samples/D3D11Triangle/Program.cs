using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using NWindowsKits;
using SampleLib;

namespace D3D11TriangleSample
{
    static class HRExtensions
    {
        public static void ThrowIfFailed(this int hr, string msg = "")
        {
            if (hr != 0)
            {
                throw new COMException(msg, hr);
            }
        }
    }

    /// <summary>
    ///  ID3DDevice
    /// </summary>
    public class D3D11Device : IDisposable
    {
        public readonly ID3D11Device Device = new ID3D11Device();
        public readonly ID3D11DeviceContext Context = new ID3D11DeviceContext();

        public void Dispose()
        {
            Device.Dispose();
            Context.Dispose();
        }

        public D3D11Device()
        {
            Span<D3D_FEATURE_LEVEL> levels = stackalloc D3D_FEATURE_LEVEL[]
            {
                D3D_FEATURE_LEVEL._11_1,
                D3D_FEATURE_LEVEL._11_0,
                D3D_FEATURE_LEVEL._10_1,
                D3D_FEATURE_LEVEL._10_0,
                D3D_FEATURE_LEVEL._9_3,
                D3D_FEATURE_LEVEL._9_2,
                D3D_FEATURE_LEVEL._9_1
            };
            var level = default(D3D_FEATURE_LEVEL);

            var flags = D3D11_CREATE_DEVICE_FLAG._BGRA_SUPPORT;
#if DEBUG
            flags |= D3D11_CREATE_DEVICE_FLAG._DEBUG;
#endif

            d3d11.D3D11CreateDevice(
                default,
                D3D_DRIVER_TYPE._HARDWARE,
                default,
                (uint)flags,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                C.D3D11_SDK_VERSION,
                ref Device.NewPtr,
                ref level,
                ref Context.NewPtr).ThrowIfFailed();
        }
    }

    /// <summary>
    /// Swapchain
    /// </summary>
    public class DXGISwapChainForHWND : IDisposable
    {
        readonly IDXGISwapChain1 m_swapChain = new IDXGISwapChain1();

        public void Dispose()
        {
            m_swapChain.Dispose();
        }

        public void Resize(int w, int h)
        {
            if (m_swapChain.Ptr != default)
            {
                DXGI_SWAP_CHAIN_DESC desc = default;
                m_swapChain.GetDesc(ref desc).ThrowIfFailed();
                m_swapChain.ResizeBuffers(desc.BufferCount,
                (uint)w,
                (uint)h,
                desc.BufferDesc.Format, desc.Flags);
            }
        }

        public ID3D11Texture2D GetBackbuffer(ID3D11Device device, HWND hWnd)
        {
            if (!m_swapChain != default)
            {
                using var dxgiDevice = new IDXGIDevice2();
                device.QueryInterface(ref IDXGIDevice2.IID, ref dxgiDevice.NewPtr).ThrowIfFailed();

                using var dxgiAdapter = new IDXGIAdapter();
                dxgiDevice.GetAdapter(ref dxgiAdapter.NewPtr).ThrowIfFailed();

                using var dxgiFactory = new IDXGIFactory2();
                dxgiAdapter.GetParent(ref IDXGIFactory2.IID, ref dxgiFactory.NewPtr).ThrowIfFailed();

                var desc = new DXGI_SWAP_CHAIN_DESC1
                {
                    Format = DXGI_FORMAT._B8G8R8A8_UNORM,
                    AlphaMode = DXGI_ALPHA_MODE._UNSPECIFIED,
                    BufferUsage = C.DXGI_USAGE_RENDER_TARGET_OUTPUT,
                    Scaling = DXGI_SCALING._NONE,
                    BufferCount = 2,
                    SwapEffect = DXGI_SWAP_EFFECT._FLIP_SEQUENTIAL,
                    SampleDesc = new DXGI_SAMPLE_DESC
                    {
                        Count = 1,
                        Quality = 0,
                    },

                };
                var fs_desc = new DXGI_SWAP_CHAIN_FULLSCREEN_DESC
                {
                    Windowed = 1,
                };
                dxgiFactory.CreateSwapChainForHwnd(device.Ptr, hWnd, ref desc, ref fs_desc, default, ref m_swapChain.NewPtr).ThrowIfFailed();
            }

            var texture = new ID3D11Texture2D();
            m_swapChain.GetBuffer(0, ref texture.GetIID(), ref texture.NewPtr).ThrowIfFailed();
            return texture;
        }

        public void Present()
        {
            m_swapChain.Present(0, 0);
        }
    }

    public struct PinPtr<T> : IDisposable
    {
        int m_offset;
        readonly GCHandle m_handle;
        public IntPtr Ptr
        {
            get
            {
                if (!m_handle.IsAllocated)
                {
                    return IntPtr.Zero;
                }
                var ptr = m_handle.AddrOfPinnedObject();
                ptr = IntPtr.Add(ptr, m_offset);
                return ptr;
            }
        }

        public void Dispose()
        {
            m_handle.Free();
        }

        public PinPtr(ArraySegment<T> segment)
        {
            m_handle = GCHandle.Alloc(segment.Array, GCHandleType.Pinned);
            m_offset = segment.Offset;
        }
    }

    public static class PinPtr
    {
        public static PinPtr<T> Create<T>(ArraySegment<T> array)
        {
            return new PinPtr<T>(array);
        }
        public static PinPtr<T> Create<T>(T[] array)
        {
            return Create(new ArraySegment<T>(array));
        }
    }

    public struct Vertex
    {
        public Vector4 pos;
        // public Vector4 color;
    };

    public class D3D11Model : IDisposable
    {
        ID3D11Buffer m_vertexBuffer = new ID3D11Buffer();
        ID3D11Buffer m_indexBuffer = new ID3D11Buffer();

        public void Dispose()
        {
            m_indexBuffer.Dispose();
            m_vertexBuffer.Dispose();
        }

        Byte[] m_vertices;
        int m_vertexSize;
        Byte[] m_indices;
        DXGI_FORMAT m_indexFormat;
        int m_indexCount;

        public void SetVertices<T>(Span<T> vertices) where T : struct
        {
            m_vertices = MemoryMarshal.Cast<T, byte>(vertices).ToArray();
            m_vertexSize = Marshal.SizeOf(typeof(T));
        }

        public void SetIndices<T>(Span<T> indices) where T : struct
        {
            m_indices = MemoryMarshal.Cast<T, byte>(indices).ToArray();
            m_indexCount = indices.Length;
            switch (Marshal.SizeOf(typeof(T)))
            {
                case 2:
                    m_indexFormat = DXGI_FORMAT._R16_UINT;
                    break;

                case 4:
                    m_indexFormat = DXGI_FORMAT._R32_UINT;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        public static D3D11Model CreateTriangle()
        {
            var model = new D3D11Model();

            var vertices = new Vertex[]{
                new Vertex{
                    pos =new Vector4(0.0f, 0.0f, 0.5f, 1.0f),
                    // color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
                },
                new Vertex{
                    pos  = new Vector4(0.5f, 0.5f, 0.5f, 1.0f),
                    // color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f)
                },
                new Vertex{
                    pos = new Vector4(0.5f, -0.5f, 0.5f, 1.0f),
                    // color = new Vector4(0.0f, 0.0f, 1.0f, 1.0f)
                }
            };
            model.SetVertices(vertices.AsSpan());

            Span<int> indices = stackalloc int[]
            {
                0,
                1,
                2
            };
            model.SetIndices(indices);

            return model;
        }

        public void Draw(ID3D11Device device, ID3D11DeviceContext context, Span<D3D11_INPUT_ELEMENT_DESC> _layout)
        {
            if (!m_vertexBuffer)
            {
                using (var pin = PinPtr.Create(m_vertices))
                {
                    var desc = new D3D11_BUFFER_DESC
                    {
                        ByteWidth = (uint)m_vertices.Length,
                        Usage = D3D11_USAGE._DEFAULT,
                        BindFlags = (uint)D3D11_BIND_FLAG._VERTEX_BUFFER,
                    };
                    var data = new D3D11_SUBRESOURCE_DATA
                    {
                        pSysMem = pin.Ptr
                    };
                    device.CreateBuffer(ref desc, ref data,
                        ref m_vertexBuffer.NewPtr).ThrowIfFailed();
                }
            }
            Span<IntPtr> pBufferTbl = stackalloc IntPtr[] { m_vertexBuffer.Ptr };
            Span<uint> SizeTbl = stackalloc uint[] { (uint)m_vertexSize };
            Span<uint> OffsetTbl = stackalloc uint[] { 0 };
            context.IASetVertexBuffers(0, 1,
                ref MemoryMarshal.GetReference(pBufferTbl),
                ref MemoryMarshal.GetReference(SizeTbl),
                ref MemoryMarshal.GetReference(OffsetTbl));

            if (!m_indexBuffer)
            {
                using (var pin = PinPtr.Create(m_indices))
                {
                    var desc = new D3D11_BUFFER_DESC
                    {
                        ByteWidth = (uint)m_indices.Length,
                        Usage = D3D11_USAGE._DEFAULT,
                        BindFlags = (uint)D3D11_BIND_FLAG._INDEX_BUFFER,
                    };
                    var data = new D3D11_SUBRESOURCE_DATA
                    {
                        pSysMem = pin.Ptr
                    };
                    device.CreateBuffer(ref desc, ref data,
                        ref m_indexBuffer.NewPtr).ThrowIfFailed();
                }
            }
            context.IASetIndexBuffer(m_indexBuffer.Ptr, m_indexFormat, 0);

            context.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
            context.DrawIndexed((uint)m_indexCount, 0, 0);
        }
    }

    public enum Semantics
    {
        POSITION,
        COLOR,
    }

    public static class SemanticsExtensions
    {
        static Byte[] position = Encoding.UTF8.GetBytes("POSITION");
        static Byte[] color = Encoding.UTF8.GetBytes("COLOR");

        static PinPtr<byte> position_pin;
        static PinPtr<byte> color_pin;

        static SemanticsExtensions()
        {
            position_pin = PinPtr.Create(position);
            color_pin = PinPtr.Create(color);
        }

        public static IntPtr Pin(this Semantics semantic)
        {
            switch (semantic)
            {
                case Semantics.POSITION: return position_pin.Ptr;
                case Semantics.COLOR: return color_pin.Ptr;
            }

            throw new NotImplementedException();
        }
    }

    public struct VertexAttribute
    {
        public readonly Semantics Semantic;
        public readonly uint SemanticIndex;

        public readonly DXGI_FORMAT Format;

        public VertexAttribute(Semantics semantic, uint semanticIndex, DXGI_FORMAT format)
        {
            Semantic = semantic;
            SemanticIndex = semanticIndex;
            Format = format;
        }
    }


    public class D3D11Shader : IDisposable
    {
        ID3D10Blob m_vs_blob = new ID3D10Blob();
        ID3D11VertexShader m_vs = new ID3D11VertexShader();

        D3D11_INPUT_ELEMENT_DESC[] m_layout;
        public D3D11_INPUT_ELEMENT_DESC[] Layout => m_layout;

        VertexAttribute[] m_vertexAttributes;
        public VertexAttribute[] VertexAttributes => m_vertexAttributes;

        ID3D10Blob m_ps_blob = new ID3D10Blob();

        ID3D11PixelShader m_ps = new ID3D11PixelShader();

        ID3D11InputLayout m_inputLayout = new ID3D11InputLayout();

        public void Dispose()
        {
            m_inputLayout.Dispose();
            m_ps.Dispose();
            m_vs.Dispose();
            m_ps_blob.Dispose();
            m_vs_blob.Dispose();
        }

        static void Compile(string source, string name, string entryPoint, string target, uint flag1, uint flag2, out ID3D10Blob dst)
        {
            var source_utf8 = Encoding.UTF8.GetBytes(source);
            // var name_utf8 = Encoding.UTF8.GetBytes(name + "\0\0");
            var entryPoint_utf8 = Encoding.UTF8.GetBytes(entryPoint + "\0\0");
            var target_utf8 = Encoding.UTF8.GetBytes(target + "\0\0");

            var def = new D3D_SHADER_MACRO[]
            {
                new D3D_SHADER_MACRO
                {
                }
            };

            dst = new ID3D10Blob();
            var error = new ID3D10Blob();
            // using (var error = new ID3D10Blob())
            using (var source_pin = PinPtr.Create(source_utf8))
            // using (var name_pin = PinPtr.Create(name_utf8))
            using (var entryPoint_pin = PinPtr.Create(entryPoint_utf8))
            using (var target_pin = PinPtr.Create(target_utf8))
            {
                var hr = d3dcompiler_47.D3DCompile(
                    source_pin.Ptr,
                    (ulong)source.Length,
                    name,
                    ref def[0],
                    new IntPtr(1),
                    entryPoint,
                    target,
                    flag1,
                    flag2,
                    ref dst.NewPtr,
                    ref error.NewPtr
                );
                if (hr != 0)
                {
                    using (error)
                    {
                        var buffer = new Byte[error.GetBufferSize()];
                        Marshal.Copy(error.GetBufferPointer(), buffer, 0, buffer.Length);
                        //var encoding = Encoding.GetEncoding(932);
                        var encoding = Encoding.UTF8;
                        var msg = encoding.GetString(buffer);
                        throw new Exception(msg);
                    }
                }
            }
        }

        public const string SampleShader = @"
struct VS_INPUT
{
    float4 Position   : POSITION;
    // float4 Color      : COLOR0;
};

struct VS_OUTPUT
{
    float4 Position   : SV_POSITION;
    // float4 Color      : COLOR0;
};

VS_OUTPUT vsMain( VS_INPUT In )
{
    VS_OUTPUT Output;
    Output.Position = In.Position;
    // Output.Color    = In.Color;
    return Output;    
}

float4 psMain( VS_OUTPUT In ) : SV_TARGET
{
    // return In.Color;
    return float4(1, 1, 1, 1);
}
";

        public static D3D11Shader CreateShader(string vs, string ps)
        {
            var shader = new D3D11Shader();
            {
                // compile. not depends on ID3D11Device
                Compile(vs, "vs", "vsMain", "vs_4_0", 0, 0, out shader.m_vs_blob);
                Compile(ps, "ps", "psMain", "ps_4_0", 0, 0, out shader.m_ps_blob);

                shader.m_vertexAttributes = new VertexAttribute[]
                {
                    new VertexAttribute(Semantics.POSITION, 0, DXGI_FORMAT._R32G32B32A32_FLOAT),
                    // new VertexAttribute(Semantics.COLOR, 0, DXGI_FORMAT._R8G8B8A8_UNORM),
                };

                shader.m_layout = new D3D11_INPUT_ELEMENT_DESC[shader.m_vertexAttributes.Length];

                {
                    for (int i = 0; i < shader.m_vertexAttributes.Length; ++i)
                    {
                        var va = shader.m_vertexAttributes[i];
                        shader.m_layout[i] = new D3D11_INPUT_ELEMENT_DESC
                        {
                            SemanticName = va.Semantic.ToString(),
                            SemanticIndex = va.SemanticIndex,
                            Format = va.Format,
                            // InputSlot = (uint)i,
                            InputSlot = 0,
                            // AlignedByteOffset = (i == 0) ? 0 : unchecked((uint)Constants.D3D11_APPEND_ALIGNED_ELEMENT),
                            AlignedByteOffset = 0,
                            InputSlotClass = D3D11_INPUT_CLASSIFICATION._VERTEX_DATA,
                            InstanceDataStepRate = 0,
                        };
                    }
                }

                return shader;
            }
        }

        public static D3D11Shader CreateSampleShader()
        {
            return CreateShader(SampleShader, SampleShader);
        }

        public void Setup(ID3D11Device device, ID3D11DeviceContext context)
        {
            if (!m_vertexAttributes.Any())
            {
                return;
            }

            if (!m_inputLayout)
            {
                var hr = device.CreateVertexShader(m_vs_blob.GetBufferPointer(), m_vs_blob.GetBufferSize(), default, ref m_vs.NewPtr);
                hr.ThrowIfFailed();
                hr = device.CreatePixelShader(m_ps_blob.GetBufferPointer(), m_ps_blob.GetBufferSize(), default, ref m_ps.NewPtr);
                hr.ThrowIfFailed();

                hr = device.CreateInputLayout(ref m_layout[0], (uint)m_layout.Length,
                            m_vs_blob.GetBufferPointer(), m_vs_blob.GetBufferSize(), ref m_inputLayout.NewPtr);
                hr.ThrowIfFailed();
            }

            // setup shader pipeline
            Span<IntPtr> classes = stackalloc IntPtr[] { };
            context.VSSetShader(m_vs.Ptr, ref MemoryMarshal.GetReference(classes), (uint)classes.Length);
            context.PSSetShader(m_ps.Ptr, ref MemoryMarshal.GetReference(classes), (uint)classes.Length);
            context.IASetInputLayout(m_inputLayout.Ptr);
        }
    }

    public class VertexBuffer : IDisposable
    {
        Memory<byte> m_bytes;
        public readonly int Stride;

        D3D11_BIND_FLAG m_bind;

        ID3D11Buffer m_buffer = new ID3D11Buffer();

        public ID3D11Buffer Buffer => m_buffer;

        public IntPtr GetPtr(ID3D11Device device)
        {
            if (!m_buffer)
            {
                var desc = new D3D11_BUFFER_DESC
                {
                    ByteWidth = (uint)m_bytes.Length,
                    Usage = D3D11_USAGE._DEFAULT,
                    BindFlags = (uint)m_bind,
                };
                if (MemoryMarshal.TryGetArray(m_bytes, out ArraySegment<byte> bytes))
                {
                    using (var pin = PinPtr.Create(bytes))
                    {
                        var data = new D3D11_SUBRESOURCE_DATA
                        {
                            pSysMem = pin.Ptr
                        };
                        device.CreateBuffer(ref desc, ref data,
                            ref m_buffer.NewPtr).ThrowIfFailed();
                    }
                }
            }
            return m_buffer.Ptr;
        }

        public VertexBuffer(Memory<byte> bytes, int stride, D3D11_BIND_FLAG bind)
        {
            m_bytes = bytes;
            Stride = stride;
            m_bind = bind;
        }

        public void Dispose()
        {
            ((IDisposable)m_buffer).Dispose();
        }
    }

    public class D3D11Mesh : IDisposable
    {
        Dictionary<Semantics, VertexBuffer> m_vertexBufferMap = new Dictionary<Semantics, VertexBuffer>();
        int m_vertexCount;
        VertexBuffer m_indexBuffer;
        int m_indexCount;
        DXGI_FORMAT m_indexFormat;

        public void Dispose()
        {
            foreach (var kv in m_vertexBufferMap)
            {
                kv.Value.Dispose();
            }
            m_vertexBufferMap.Clear();
            m_indexBuffer.Dispose();
            m_indexBuffer = null;
        }

        public void SetVertexAttribute(Semantics semantic, Memory<byte> bytes, int stride)
        {
            if (m_vertexCount == 0)
            {
                m_vertexCount = bytes.Length / stride;
            }
            else
            {
                if (m_vertexCount != bytes.Length / stride)
                {
                    throw new Exception("different vertex count");
                }
            }
            m_vertexBufferMap[semantic] = new VertexBuffer(bytes, stride, D3D11_BIND_FLAG._VERTEX_BUFFER);
        }

        public void UpdateVertexAttribute(ID3D11Device device, ID3D11DeviceContext context, Semantics semantic, Memory<byte> bytes)
        {
            var buffer = m_vertexBufferMap[semantic];

            if (MemoryMarshal.TryGetArray(bytes, out ArraySegment<byte> segment))
            {
                using (var pin = PinPtr.Create(segment))
                {
                    var box = new D3D11_BOX
                    {
                    };
                    context.UpdateSubresource(buffer.Buffer.Ptr, 0, ref box, pin.Ptr, 0, 0);
                }
            }
        }

        public void SetIndices(Memory<byte> bytes, int stride)
        {
            if (m_indexBuffer != null)
            {
                throw new Exception("duplicate index buffer");
            }
            m_indexBuffer = new VertexBuffer(bytes, stride, D3D11_BIND_FLAG._INDEX_BUFFER);
            m_indexCount = bytes.Length / stride;
            switch (stride)
            {
                case 2:
                    m_indexFormat = DXGI_FORMAT._R16_UINT;
                    break;

                case 4:
                    m_indexFormat = DXGI_FORMAT._R32_UINT;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }


        public void Draw(ID3D11Device device, ID3D11DeviceContext context, Span<VertexAttribute> layout)
        {
            Span<IntPtr> buffers = stackalloc IntPtr[layout.Length];
            Span<uint> strides = stackalloc uint[layout.Length];
            Span<uint> offsets = stackalloc uint[layout.Length];
            for (int i = 0; i < layout.Length; ++i)
            {
                var va = layout[i];
                if (m_vertexBufferMap.TryGetValue(va.Semantic, out VertexBuffer vb))
                {
                    buffers[i] = vb.GetPtr(device);
                    strides[i] = (uint)vb.Stride;
                }
            }
            context.IASetVertexBuffers(0, (uint)layout.Length,
                ref MemoryMarshal.GetReference(buffers),
                ref MemoryMarshal.GetReference(strides),
                ref MemoryMarshal.GetReference(offsets));

            context.IASetIndexBuffer(m_indexBuffer.Buffer.Ptr, m_indexFormat, 0);
            context.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
            context.DrawIndexed((uint)m_indexCount, 0, 0);
        }
        public static D3D11Mesh CreateTriangle()
        {
            var model = new D3D11Mesh();

            var positions = new Vector3[]{
                new Vector3(0.0f, 0.0f, 0.0f),
                new Vector3(0.5f, 0.5f, 0.0f),
                new Vector3(0.5f, -0.5f, 0.0f),
            };
            var positionSpan = MemoryMarshal.Cast<Vector3, byte>(positions.AsSpan());
            model.SetVertexAttribute(Semantics.POSITION,
                positionSpan.ToArray().AsMemory(),
                Marshal.SizeOf(positions[0].GetType()));

            var colors = new Vector4[]{
                new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
                new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
                new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
            };
            var colorSpan = MemoryMarshal.Cast<Vector4, byte>(colors.AsSpan());
            model.SetVertexAttribute(Semantics.COLOR,
                colorSpan.ToArray().AsMemory(),
                Marshal.SizeOf(colors[0].GetType()));

            Span<int> indices = stackalloc int[]
            {
                0,
                1,
                2
            };
            var indexSpan = MemoryMarshal.Cast<int, byte>(indices);
            model.SetIndices(indexSpan.ToArray(), 4);

            return model;
        }
    }

    public class D3D11ConstantBuffer<T> : IDisposable
    where T : struct
    {
        ID3D11Buffer m_constantBuffer = new ID3D11Buffer();

        T[] m_constants = new T[1];
        public ref T Value
        {
            get
            {
                return ref m_constants[0];
            }
        }

        uint m_slot;

        public D3D11ConstantBuffer(uint slot)
        {
            m_slot = slot;
        }

        public void Dispose()
        {
            ((IDisposable)m_constantBuffer).Dispose();
        }

        public void Set(ID3D11Device device, ID3D11DeviceContext context)
        {
            // create
            if (!m_constantBuffer)
            {
                var desc = new D3D11_BUFFER_DESC
                {
                    ByteWidth = (uint)Marshal.SizeOf(typeof(T)),
                    Usage = D3D11_USAGE._DEFAULT,
                    BindFlags = (uint)D3D11_BIND_FLAG._CONSTANT_BUFFER,
                };
                using (var pin = PinPtr.Create(m_constants))
                {
                    var data = new D3D11_SUBRESOURCE_DATA
                    {
                        pSysMem = pin.Ptr,
                    };
                    device.CreateBuffer(ref desc, ref data, ref m_constantBuffer.NewPtr).ThrowIfFailed();
                }
            }

            // update
            using (var pin = PinPtr.Create(m_constants))
            {
                var box = new D3D11_BOX
                {
                };
                context.UpdateSubresource(m_constantBuffer.Ptr, 0, ref box, pin.Ptr, 0, 0);
            }

            Span<IntPtr> buffers = stackalloc IntPtr[]
            {
                m_constantBuffer.Ptr,
            };
            context.VSSetConstantBuffers(m_slot, (uint)buffers.Length, ref MemoryMarshal.GetReference(buffers));
        }
    }


    class D3DApp : IDisposable
    {
        D3D11Device m_d3d11;
        DXGISwapChainForHWND m_swapchain;
        D3D11Shader m_shader;
        D3D11Model m_model;

        public void Dispose()
        {
            m_model.Dispose();
            m_swapchain.Dispose();
            m_d3d11.Dispose();
        }

        public D3DApp()
        {
            m_d3d11 = new D3D11Device();
            m_swapchain = new DXGISwapChainForHWND();
            m_shader = D3D11Shader.CreateSampleShader();
            m_model = D3D11Model.CreateTriangle();
        }

        public void Resize(HWND _, int w, int h)
        {
            m_swapchain.Resize(w, h);
        }

        ID3D11RenderTargetView Begin(HWND hWnd, out float width, out float height)
        {
            using (var texture = m_swapchain.GetBackbuffer(m_d3d11.Device, hWnd))
            {
                D3D11_TEXTURE2D_DESC desc = default;
                texture.GetDesc(ref desc);
                width = (float)desc.Width;
                height = (float)desc.Height;

                var rtv_desc = new D3D11_RENDER_TARGET_VIEW_DESC
                {
                    Format = desc.Format,
                    ViewDimension = D3D11_RTV_DIMENSION._TEXTURE2D
                };
                var rtv = new ID3D11RenderTargetView();
                m_d3d11.Device.CreateRenderTargetView(texture.Ptr, ref rtv_desc, ref rtv.NewPtr).ThrowIfFailed();
                return rtv;
            }
        }

        void End()
        {
            m_d3d11.Context.Flush();
            m_swapchain.Present();
        }

        public void Draw(HWND hWnd)
        {
            if (m_d3d11 == null)
            {
                return;
            }

            using var rtv = Begin(hWnd, out float width, out float height);
            {
                // clear
                var clearColor = new Vector4(0.0f, 0.125f, 0.3f, 1.0f);
                m_d3d11.Context.ClearRenderTargetView(rtv.Ptr, ref clearColor.X);

                // draw pipeline
                m_d3d11.Context.OMSetRenderTargets(1, ref rtv.Ptr, default);
                var vp = new D3D11_VIEWPORT
                {
                    Width = width,
                    Height = height,
                    MinDepth = 0.0f,
                    MaxDepth = 1.0f,
                };
                m_d3d11.Context.RSSetViewports(1, ref vp);

                m_shader.Setup(m_d3d11.Device, m_d3d11.Context);

                m_model.Draw(m_d3d11.Device, m_d3d11.Context, m_shader.Layout.AsSpan());

                // flush
                End();
            }
        }
    }

    class Program
    {
        [STAThread]
        static void Main(string[] _)
        {
            var size = Marshal.SizeOf(typeof(D3D11_INPUT_ELEMENT_DESC));

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var window = SampleLib.Window.Create();
            if (window == null)
            {
                throw new Exception("fail to create window");
            }

            using (var d3d = new D3DApp())
            {
                window.OnResize += (w, h) =>
                {
                    d3d.Resize(window.WindowHandle, w, h);
                };

                MessageLoop.Run(() =>
                {

                    d3d.Draw(window.WindowHandle);

                }, 30);
            }
        }
    }
}
