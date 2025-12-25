using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using klalikTest.Services;
using System.Collections.Generic;

namespace klalikTest
{
    public partial class MainWindow : Window
    {
        private Stack<object> _history = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnLoaded(RoutedEventArgs e)
        {
            base.OnLoaded(e);
            NavigationService.NavigateToUserControl1();
        }
    }
}