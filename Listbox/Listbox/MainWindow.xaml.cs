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

namespace Listbox
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
        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem replace = new ListBoxItem();
            replace.Content = txtReplace.Text;
            simpleListBox.Items[simpleListBox.SelectedIndex] = replace;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = txtAdd.Text;
            simpleListBox.Items.Add(item);

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        
        {
        //    int index = 0; // Start bij 0
        //    bool found = false;

        //    foreach (ListBoxItem item in simpleListBox.Items)
        //    {
        //        Vergelijk de inhoud van het huidige item met de zoektekst
        //        if (item.Content.ToString().Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
        //        {
        //            found = true;
        //            break;
        //        }
        //        index++;
        //    }

        //    Toon het resultaat
        //    if (found)
        //    {
        //        searchLabel.Content = $"Naam komt voor op plaats {index + 1}";
        //    }
        //    else
        //    {
        //        searchLabel.Content = "Naam niet gevonden";
        //    }
        //}

            int index = 0;
            foreach (ListBoxItem item in simpleListBox.Items)
            {
                if (item.Content.ToString().Equals(txtSearch.Text))
                {
                    break;
                }
                else
                {
                    index++;
                }
             }
            searchLabel.Content = $"naam komt voor op plaats {index + 1}";

        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            simpleListBox.Items.Remove(simpleListBox.SelectedItem);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            simpleListBox.Items.Clear();
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            // Maak een string[] array van de ListBox items
            string[] name = new string[simpleListBox.Items.Count];

            for (int i = 0; i < simpleListBox.Items.Count; i++)
            {
                ListBoxItem listItem = (ListBoxItem)simpleListBox.Items[i];
                name[i] = listItem.Content.ToString();
            }
            // Sorteer de array
            Array.Sort(name);
            // Wis de ListBox en voeg de gesorteerde items toe
            simpleListBox.Items.Clear();


            foreach (string str in name)
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.Content = str;
                simpleListBox.Items.Add(newItem);
            }
        }
    }
}