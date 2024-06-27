using ListBox.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name="Jannick",Age=30},
            new Person{Name="Maria",Age=20},
            new Person{Name="Scott",Age=35},
            new Person{Name="ClearLove",Age=20},
            new Person{Name="Zmjjkk",Age=20},
            new Person{Name="Shy",Age=40}
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People ;
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }

        }
    }
}