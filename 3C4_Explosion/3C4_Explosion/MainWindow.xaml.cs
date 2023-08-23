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

namespace _3C4_Explosion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Person> Persons = new List<Person>();
        }

        private void Button_AddClick(object sender, RoutedEventArgs e)
        {
            if(true)
            {
                Person person = new(123, "Mobius");
            }
        }

        private void Button_UpdateClick(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class Person
    {
        int Id { get; init; }
        string Name { get; set; }
        int? PhoneNumber { get; set; }
        string? Email { get; set; }
        string? Address { get; set; }
        public Person(int id, string name, int? num = null, string? email = null, string? adress = null)
        {
            Id = id; Name = name; PhoneNumber = num; Email = email; Address = adress;
        }
    }
}
