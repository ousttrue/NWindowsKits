namespace SampleLib
{
    public static class ThrowIfFailedExtensions
    {
        public static void ThrowIfFailed(this int hr)
        {
            if (hr != 0)
            {
                throw new NWindowsKits.ComException(hr);
            }
        }
    }
}
