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
using PrintManagementSystem_Шаповалов.Classes;

namespace PrintManagementSystem_Шаповалов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<TypeOperation> typeOperationList = TypeOperation.AllTypeOpertation();
        public List<Format> formatsList = Format.AllFormats();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            foreach(TypeOperation items in typeOperationList) 
                typeOperation.Items.Add(items.name);
            foreach(Format item in formatsList)
                formats.Items.Add(item.format);
        }
        
        private void textBoxCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool cont;

        }

        private void DeleteOperation(object sender, RoutedEventArgs e)
        {

        }

        private void EditOperation(object sender, RoutedEventArgs e)
        {

        }

        private void SelectedType(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SelectedFormat(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBoxCount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddOperation(object sender, RoutedEventArgs e)
        {

        }

        private void ColorsChange(object sender, RoutedEventArgs e)
        {

        }
    }
}
