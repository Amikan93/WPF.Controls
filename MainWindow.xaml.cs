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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Controls
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

       //// private void TbControlList_OnSelectionChanged_(object sender, SelectionChangedEventArgs e)
       // {
       //     MessageBox.Show("work")
       // }
       private void Expander_Expanded(object sender, RoutedEventArgs e)
       {
           //проверяем Expander обращаемся к children
           var result = spExpanded.Children.OfType<Expander>().ToList();

           //Перебираем все Expander 
           foreach (var item in spExpanded.Children)
           {
               Expander data = (Expander)item;

               if ((Expander)sender != data)
                   data.IsExpanded = false;
               else
                   data.IsExpanded = true;

           }
       }

       private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
       {
           tbItem_2.IsEnabled = true;
       }

       private void ButtonBase_OnClick_1(object sender, RoutedEventArgs e)
       {
           tbItem_2.IsEnabled = false;
        }

       //отлавливаем действие по кнопке
       private void tbControlList_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {
           
       }

       private void Button_Click_2(object sender, RoutedEventArgs e)
       {
           MessageBox.Show(pswPassword.Password + " / " + tbxName.Text);
       }

       private void Button_Click_3(object sender, RoutedEventArgs e)
       {
           lbCities.Items.Add(tbxAddCity.Text);
       }

       private void LbCities_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
       {
           MessageBox.Show("test");
       }
    }
}
