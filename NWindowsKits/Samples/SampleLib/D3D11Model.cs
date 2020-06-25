using System;
using System.Numerics;
using System.Runtime.InteropServices;
using NWindowsKits;

namespace SampleLib
{
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
                        ref m_vertexBuffer.PtrForNew).ThrowIfFailed();
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
                        ref m_indexBuffer.PtrForNew).ThrowIfFailed();
                }
            }
            context.IASetIndexBuffer(m_indexBuffer.Ptr, m_indexFormat, 0);

            context.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
            context.DrawIndexed((uint)m_indexCount, 0, 0);
        }
    }
}
