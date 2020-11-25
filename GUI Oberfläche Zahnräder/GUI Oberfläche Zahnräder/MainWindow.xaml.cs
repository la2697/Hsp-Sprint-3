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

namespace GUI_Oberfläche_Zahnräder
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public const double Pi = Math.PI;
        public const double S235JR = 0.00785; // Dichte S235JR 
        public const double dGJL = 7.15 / 1000; //Dichte EN-GJL-200
        public const double dGJS = 7.1 / 1000; //Dichte EN-GJS-350
        public const double PrS235 = 3.63; // Preis S235JR
        public const double PrdGjl = 0.80; // Preis EN-GJL-200
        public const double PrGjs = 1.10; // Preis EN-GJS-350
        public const double c = 0.167; // Kopfspiel Standard
        public const double c1 = 0.1; // Kopfspiel DIN 867
        public const double c2 = 0.3; // Kopfspiel DIN 867
        public static double cosα = Math.Cos(20); // Normverzahnung cos20°

        public MainWindow()
        {


        }

        private void txt_Fußhöhe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_Kopfhöhe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rtb_Gerad_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Bestätigen_Click(object sender, RoutedEventArgs e)
        {
            if (rtb_EN_GJL.IsChecked == true)
            {
                lb_Werkstoffwahl.Content = "EN-GJl";
            }
            else if (rtb_EN_GJS.IsChecked == true)
            {
                lb_Werkstoffwahl.Content = "EN-GJS";
            }
            else if (rtb_S235JR.IsChecked == true)
            {
                lb_Werkstoffwahl.Content = "S235JR";
            }



        }



    }
}

      


   




