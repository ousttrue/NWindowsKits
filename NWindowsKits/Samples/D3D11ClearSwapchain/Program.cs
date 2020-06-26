using System;
using System.Numerics;
using System.Runtime.InteropServices;
using NWindowsKits;
using SampleLib;

namespace Sample
{
    class D3DApp : IDisposable
    {
        ID3D11Device m_pDevice = new ID3D11Device();

        ID3D11DeviceContext m_pContext = new ID3D11DeviceContext();
        IDXGISwapChain m_swapChain = new IDXGISwapChain();

        bool m_disposed;

        public void Dispose()
        {
            m_disposed = true;
        }

        void EnsureDevice(HWND hWnd)
        {
            if (m_pDevice.Ptr != default)
            {
                return;
            }
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

            var desc = new DXGI_SWAP_CHAIN_DESC
            {
                BufferDesc = new DXGI_MODE_DESC
                {
                    Width = 0,
                    Height = 0,
                    RefreshRate = new DXGI_RATIONAL
                    {
                        Numerator = 60,
                        Denominator = 1,
                    },
                    Format = DXGI_FORMAT._R8G8B8A8_UNORM_SRGB,
                },
                SampleDesc = new DXGI_SAMPLE_DESC
                {
                    Count = 1,
                    Quality = 0,
                },
                BufferUsage = C.DXGI_USAGE_RENDER_TARGET_OUTPUT,
                BufferCount = 1,
                Windowed = 1,
                OutputWindow = hWnd,
            };

            var hr = d3d11.D3D11CreateDeviceAndSwapChain(
                default,
                D3D_DRIVER_TYPE._HARDWARE,
                default,
                (uint)D3D11_CREATE_DEVICE_FLAG._DEBUG,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                C.D3D11_SDK_VERSION,
                ref desc,
                ref m_swapChain.NewPtr,
                ref m_pDevice.NewPtr,
                ref level,
                ref m_pContext.NewPtr);

            if (m_pDevice.GetFeatureLevel() != level)
            {
                throw new Exception("feature level");
            }

            Console.WriteLine("CreateDevice: {0}, D3D_FEATURE_LEVEL = {1}", hr, level);
        }

        public void Resize(HWND hWnd, int w, int h)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            m_swapChain.ResizeBuffers(1, (uint)w, (uint)h, DXGI_FORMAT._R8G8B8A8_UNORM, 0);
        }

        public void Draw(HWND hWnd)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            using (var texture = new ID3D11Texture2D())
            {
                DXGI_SWAP_CHAIN_DESC desc = default;
                m_swapChain.GetDesc(ref desc);
                m_swapChain.GetBuffer(0, ref ID3D11Texture2D.IID, ref texture.NewPtr).ThrowIfFailed();

                D3D11_TEXTURE2D_DESC tdesc = default;
                texture.GetDesc(ref tdesc);

                // _rtv
                var rtv_desc = new D3D11_RENDER_TARGET_VIEW_DESC
                {
                    Format = DXGI_FORMAT._R8G8B8A8_UNORM_SRGB,
                    ViewDimension = D3D11_RTV_DIMENSION._TEXTURE2D
                };
                var pRTV = new ID3D11RenderTargetView();
                var hr = m_pDevice.CreateRenderTargetView(texture.Ptr, ref rtv_desc, ref pRTV.NewPtr);
                if (hr != 0)
                {
                    var uhr = (uint)hr;
                    throw new COMException("CreateRenderTargetView", hr);
                }
                using (pRTV)
                {
                    var clearColor = new Vector4(0.0f, 0.125f, 0.3f, 1.0f);
                    m_pContext.ClearRenderTargetView(pRTV.Ptr, ref clearColor.X);
                }
            }

            m_pContext.Flush();
            m_swapChain.Present(0, 0);
        }
    }

    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int WNDPROC(IntPtr hwnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        [STAThread]
        static void Main(string[] _)
        {
            var window = Window.Create();
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
