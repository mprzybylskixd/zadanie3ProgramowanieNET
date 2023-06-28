using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WpfApp6;
/// <summary>
/// Logika interakcji dla klasy ListaOsób.xaml
/// </summary>
public partial class ListaFilmów : Window
{
    private const string ścieżkaIO = "listaFilmów.xml";
    public ObservableCollection<Film> Filmy { get; set; } = new ObservableCollection<Film>();

    ListBox lista;
    public ListaFilmów()
    {
        DataContext = this;
        InitializeComponent();
        lista = (ListBox)this.FindName("Lista");
    }

    private void Edytuj(object sender, RoutedEventArgs e)
    {
        new WidokFilmu(
            (Film)lista.SelectedItem
            ).Show();
    }

    private void Dodaj(object sender, RoutedEventArgs e)
    {
        Film nowa = new Film();
        Filmy.Add(nowa);
        new WidokFilmu(
            nowa
            ).Show();
    }

    private void Usuń(object sender, RoutedEventArgs e)
    {
        Filmy.Remove(
            (Film)lista.SelectedItem
            );
    }

    private void Importuj(object sender, RoutedEventArgs e)
    {
        XmlSerializer serializator
            = new XmlSerializer(typeof(ObservableCollection<Film>));
        FileStream strumieńOdczytu = new FileStream(ścieżkaIO, FileMode.Open);
        ObservableCollection<Film> filmy
            = (ObservableCollection<Film>)serializator.Deserialize(
                strumieńOdczytu
                );
        //Osoby = osoby; //nie działa, bo wiązanie jest do instancji
        strumieńOdczytu.Close();
        foreach (Film film in filmy)
            Filmy.Add(film);
    }

    private void Eksportuj(object sender, RoutedEventArgs e)
    {
        XmlSerializer serializator
            = new XmlSerializer(typeof(ObservableCollection<Film>));
        TextWriter strumieńZapisu = new StreamWriter(ścieżkaIO);
        serializator.Serialize(strumieńZapisu, Filmy);
        strumieńZapisu.Close();
    }
}
