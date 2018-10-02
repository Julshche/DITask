using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace DITask.Style
{

    internal static class LocalExtensions
    {
        public static void ForWindowFromTemplate(this object templateFrameworkElement, Action<Window> action)
        {
            if (((FrameworkElement)templateFrameworkElement).TemplatedParent is Window window) action(window);
        }

        public static IntPtr GetWindowHandle(this Window window)
        {
            WindowInteropHelper helper = new WindowInteropHelper(window);
            return helper.Handle;
        }
    }
    class MyStyle
    {
        public static readonly RoutedCommand Close = new RoutedCommand();

        // commmand for style buttons
        private void CloseApp(object sender, ExecutedRoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w => SystemCommands.CloseWindow(w));
        }
        private void MaxApp(object sender, ExecutedRoutedEventArgs e)
        {
            sender.ForWindowFromTemplate(w =>
            {
                if (w.WindowState == WindowState.Maximized) SystemCommands.RestoreWindow(w);
                else SystemCommands.MaximizeWindow(w);
            });
        }
        private void MinApp(object sender, ExecutedRoutedEventArgs e)
        {
           sender.ForWindowFromTemplate(w => SystemCommands.MinimizeWindow(w));
        }
    }
}
