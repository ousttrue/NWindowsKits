using System;
using NWindowsKits;

namespace DXGIEnumerateAdapters
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new IDXGIFactory();
            var hr = dxgi.CreateDXGIFactory(ref factory.GetIID(), ref factory.PtrForNew);
            if (hr != 0)
            {
                throw new ComException(hr);
            }

            for (uint i = 0; ; ++i)
            {
                var adapter = new IDXGIAdapter();
                hr = factory.EnumAdapters(i, ref adapter.PtrForNew);
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
