using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klalikTest.Services
{
    public static class NavigationService
    {
        private static Stack<object> _history = new();

        public static MainWindow MainWindow { get; set; }
        public static object CurrentPage => MainWindow?.ContentContainer.Content;

        public static void NavigateTo(object content, bool saveToHistory = true)
        {
            if (MainWindow == null) return;

            if (saveToHistory && CurrentPage != null)
            {
                _history.Push(CurrentPage);
            }

            MainWindow.ContentContainer.Content = content;
        }

        public static void NavigateToUserControl1() => NavigateTo(new UserControl1());
        public static void NavigateToUserControl2() => NavigateTo(new UserControl2());

        public static bool CanGoBack => _history.Count > 0;

        public static void GoBack()
        {
            if (CanGoBack)
            {
                MainWindow.ContentContainer.Content = _history.Pop();
            }
        }

        public static void ClearHistory()
        {
            _history.Clear();
        }
    }
}
