using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Wargame
{
    //here be dragons :)
    class Napló
    {
        static bool _isInitialised, _useWinForms, _useCrossThreadAccess;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        public static ListBox WinFormsNaplóVezérlő { get; set; }
        public static void Naplózás(string üzenet)
        {
            if (!_isInitialised) Initialise();

            if (_useWinForms)
            {
                if (!_useCrossThreadAccess) WinFormsNaplóVezérlő.Items.Add(üzenet);
                else WinFormsNaplóVezérlő.Invoke(new Action(() => WinFormsNaplóVezérlő.Items.Add(üzenet)));
            }
            else Console.WriteLine(üzenet);
        }

        static void Initialise()
        {
            _useWinForms = GetConsoleWindow() == IntPtr.Zero && WinFormsNaplóVezérlő != null;
            _useCrossThreadAccess = WinFormsNaplóVezérlő != null && WinFormsNaplóVezérlő.InvokeRequired;
            _isInitialised = true;
        }
    }
}