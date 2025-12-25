using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using klalikTest.Data;
using klalikTest.Services;
using System;

namespace klalikTest;

public partial class UserControl1 : UserControl
{
    public UserControl1()
    {
        InitializeComponent();
        var Context = new AppDbContext();
    }

    private void LoginBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (LoginTxt.Text == "ﬂ–”—— »…" & PassTxt.Text == "zzz")
        {
            NavigationService.NavigateToUserControl2();
        }
    }
}