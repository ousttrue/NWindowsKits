using System;
using NWindowsKits;

namespace HelloWorld
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        }

        static int wWinMain(HMODULE hInstance, HMODULE _, string pCmdLine, int nCmdShow)
        {
            // Register the window class.
            var CLASS_NAME = "Sample Window Class";

            var wc = new WNDCLASSW { };

            wc.lpfnWndProc = WindowProc;
            wc.hInstance = hInstance;
            wc.lpszClassName = CLASS_NAME;

            user32.RegisterClassW(ref wc);

            // Create the window.

            var hwnd = user32.CreateWindowExW(
                0,                              // Optional window styles.
                CLASS_NAME,                     // Window class
                "Learn to Program Windows",    // Window text
                WS_._OVERLAPPEDWINDOW,            // Window style

                // Size and position
                CW_._USEDEFAULT, CW_._USEDEFAULT, CW_._USEDEFAULT, CW_._USEDEFAULT,

                default,       // Parent window    
                default,       // Menu
                hInstance,  // Instance handle
                default        // Additional application data
                );

            if (hwnd.ptr == default)
            {
                return 0;
            }

            user32.ShowWindow(hwnd, nCmdShow);

            // Run the message loop.
            var msg = new MSG { };
            while (user32.GetMessageW(ref msg, default, 0, 0) != 0)
            {
                user32.TranslateMessage(ref msg);
                user32.DispatchMessage(ref msg);
            }

            return 0;
        }

        static long WindowProc(HWND hwnd, uint uMsg, ulong wParam, long lParam)
        {
            switch (uMsg)
            {
                case WM_._DESTROY:
                    user32.PostQuitMessage(0);
                    return 0;

                case WM_._PAINT:
                    {
                        PAINTSTRUCT ps = default;
                        var hdc = user32.BeginPaint(hwnd, ref ps);

                        // All painting occurs here, between BeginPaint and EndPaint.
                        var hbrush = new HBRUSH
                        {
                            ptr = new IntPtr(COLOR_._WINDOW + 1),
                        };
                        user32.FillRect(hdc, ref ps.rcPaint, hbrush);
                        user32.EndPaint(hwnd, ref ps);
                    }
                    return 0;
            }

            return user32.DefWindowProcW(hwnd, uMsg, wParam, lParam);
        }
    }
}
