using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using klalikTest.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace klalikTest;

public partial class UserControl2 : UserControl
{
    public List<Tovari> Tovarka;
    public UserControl2()
    {
        InitializeComponent();
        var Context = new AppDbContext();
        Tovarka = Context.Tovaris.ToList();
        Tovari = new ObservableCollection<Tovari>();
        LoadData();
        DataContext = this;
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<Tovari> _tovari;
    public ObservableCollection<Tovari> Tovari
    {
        get => _tovari;
        set
        {
            _tovari = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tovari)));
        }
    }
    public void LoadData()
    {
        foreach (Tovari t in Tovarka)
        {
            Tovari.Add(t);
        }    
    }
}