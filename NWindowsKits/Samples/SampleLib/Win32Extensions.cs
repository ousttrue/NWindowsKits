namespace SampleLib
{
    public static class Win32Extensions
    {
        public static short LOWORD(this long value)
        {
            return (short)value;
        }

        public static short HIWORD(this long value)
        {
            return (short)(value >> 16);
        }

        public static short HIWORD(this ulong value)
        {
            return (short)(value >> 16);
        }
    }
}
