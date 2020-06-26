using System;
using NWindowsKits;

namespace DXGIEnumerateAdapters
{
    class Program
    {
        static void Main(string[] args)
        {
            using var factory = new IDXGIFactory();

            var hr = dxgi.CreateDXGIFactory(ref factory.GetIID(), ref factory.NewPtr);
            if (hr != 0)
            {
                throw new System.Runtime.InteropServices.COMException("CreateDXGIFactory", hr);
            }

            for (uint i = 0; ; ++i)
            {
                using var adapter = new IDXGIAdapter();
                hr = factory.EnumAdapters(i, ref adapter.NewPtr);
                if (hr != 0)
                {
                    break;
                }

                DXGI_ADAPTER_DESC desc = default;
                adapter.GetDesc(ref desc);
                Console.WriteLine(desc.Description);
            }
        }
    }
}
