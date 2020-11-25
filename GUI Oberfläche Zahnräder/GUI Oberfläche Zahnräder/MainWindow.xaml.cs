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

        


        
        private void btn_Bestätigen_Click(object sender, RoutedEventArgs e)
        {
            if (rtb_EN_GJL.IsChecked == true)
            {
                lb_Werkstoffwahl.Content = "EN-GJl-200";
            }
            else if (rtb_EN_GJS.IsChecked == true)
            {
                lb_Werkstoffwahl.Content = "EN-GJS-350";
            }
            else if (rtb_S235JR.IsChecked == true)
            {
                lb_Werkstoffwahl.Content = "S235JR";
            }

            if(rtb_0_1.IsChecked == true)
            {
                lb_Kopfspiele1.Content = "0,1";
            }
            else if(rtb_0_3.IsChecked == true)
            {
                lb_Kopfspiele1.Content = "0,3";
            }
            else if(rtb_Standard.IsChecked == true)
            {
                lb_Kopfspiele1.Content = "0,167";
            }

            lb_Modul2.Content = (txt_Modul.Text);
            lb_Zähne.Content  = txt_Zähnezahl.Text;
            lb_Dicke1.Content = txt_Dicke.Text;



            if (rtb_EN_GJL.IsChecked == true || rtb_EN_GJS.IsChecked == true || rtb_S235JR.IsChecked == true)

            {
                //Berechnung Teilkreisdurchmesser d
                try
                {
                    tb_Teilkreisdurchmesser.Text = (float.Parse(txt_Modul.Text) * float.Parse(txt_Zähnezahl.Text)).ToString();
                }
                catch
                {

                }

                //Berechnung Kopfkreisdurchmesser da
                try
                {
                    tb_Kopfkreisdurchmesser.Text = (float.Parse(tb_Teilkreisdurchmesser.Text) + (2 * float.Parse(txt_Modul.Text))).ToString();
                }
                catch
                {

                }

                //Berechnung Fußkreisdurchmesser df
                try
                {
                    tb_Fußkreisdurchmesser.Text = (float.Parse(tb_Teilkreisdurchmesser.Text) - (2 * (float.Parse(txt_Modul.Text)+c))).ToString();
                }
                catch
                {

                }

                //Berechnung Teilung p
                try
                {
                    tb_Teilung.Text = (Pi * (float.Parse(txt_Modul.Text))).ToString();
                }
                catch
                {

                }

                //Berechnung Zahnkopfhöhe ha
                try
                {
                    tb_Zahnkopfhöhe.Text = (txt_Modul.Text).ToString();
                }
                catch
                {

                }

                //Berechnung Zahnfußhöhe hf
                try
                {
                    tb_Zahnfußhöhe.Text = (float.Parse(txt_Modul.Text) + c).ToString();
                }
                catch
                {

                }

            } 

            if (rtb_EN_GJL.IsChecked == true)
            {
                try
                {
                    tb_Gewicht.Text = (dGJL * (float.Parse(txt_Dicke.Text) * ((float.Parse(tb_Teilkreisdurchmesser.Text) * (float.Parse(tb_Teilkreisdurchmesser.Text) * Pi)))) / 4).ToString();
                }
                catch
                {

                }

                //Berechnung Preis
                try
                {
                    tb_Preis.Text = (float.Parse(tb_Gewicht.Text) * PrdGjl).ToString();
                }
                catch
                {

                }

            }
            else if (rtb_EN_GJS.IsChecked == true)
            {
                try
                {
                    tb_Gewicht.Text = (dGJS * (float.Parse(txt_Dicke.Text) * ((float.Parse(tb_Teilkreisdurchmesser.Text) * (float.Parse(tb_Teilkreisdurchmesser.Text) * Pi)))) / 4).ToString();
                }
                catch
                {

                }

                //Berechnung Preis
                try
                {
                    tb_Preis.Text = (float.Parse(tb_Gewicht.Text) * PrGjs).ToString();
                }
                catch
                {

                }

            }

            else if (rtb_S235JR.IsChecked == true)
            {
                try
                {
                    tb_Gewicht.Text = (S235JR * (float.Parse(txt_Dicke.Text) * ((float.Parse(tb_Teilkreisdurchmesser.Text) * (float.Parse(tb_Teilkreisdurchmesser.Text) * Pi)))) / 4).ToString();
                }
                catch
                {

                }

                //Berechnung Preis
                try
                {
                    tb_Preis.Text = (float.Parse(tb_Gewicht.Text) * PrS235).ToString();
                }
                catch
                {

                }

            }


        }

        
        



    }
}

      


   




