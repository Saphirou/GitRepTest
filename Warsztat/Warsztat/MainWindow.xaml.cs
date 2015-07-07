using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Warsztat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public abstract class osoba
    {
       protected string imie, nazwisko, adres, email;
       protected int id_klient, nr_telefonu;
        protected List <pojazd> lista_pojazdow_klienta;
       protected void dodaj();
       protected void usun();
       protected void edytuj();
    }
    public abstract class pojazd
    {
        protected string marka, model, nr_rejestracyjny;
        protected int id_klienta, rocznik, przebieg;
        protected List<naprawa> lista_napraw_pojazdu;
        protected void dodaj();
        protected void usun();
        protected void edytuj();

    }
    public abstract class naprawa 
    {
        //Na tym to ja się nie znam... Wpisz co jest ważne.
    }
}
