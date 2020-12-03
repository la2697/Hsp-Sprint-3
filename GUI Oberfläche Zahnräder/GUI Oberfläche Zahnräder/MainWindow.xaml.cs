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

        //Zahlencheck
        public bool Zahlenprüfung(string Zahlencheck)
        {
            try
            {
                double doublezahl = double.Parse(Zahlencheck);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public class Außenverzahnung
        {
            //Eingabevariablen
            public double m;                            //Modul
            public double c;                            //Kopfspiel Standard
            public double d;                            //Teilkreisdurchmesser
            public double z;                            //Zähnezahl
            public double t;                            //Werkstoffdicke


            //Help
            public int Fehler;

            //Werkstoffangaben
            public double Preis_S235JR = 3.63;          //Preis S235JR
            public double Preis_GJL = 0.80;             //Preis GJL
            public double Preis_GJS = 1.10;             //Preis GJS


            //Ausgabevariablen
            public double h;                            //Zahnhöhe
            public double ha;                           //Zahnkopfhöhe
            public double hf;                           //Zahnfußhöhe
            public double df;                           //Fußkreisdurchmesser
            public double da;                           //Kopfkreisdurchmesser
            public double p;                            //Teilung
            public double material;                     //Materialdichte g/cm3
            public double preis;                        //Preis pro kg
            public double A;                            //Flächeninhalt mm2
            public double V;                            //Volumen mm3
            public double M;                            //Masse g
            public double Wert;                         //Preis

           


            public void Berechnung()
            {
                //Formeln
                d = m * z;
                h = (2 * m) + c;
                p = Math.PI * m;
                da = d + (2 + m);
                ha = m;
                hf = m + c;
                df = d - 2 * (m + c);
                A = (Math.PI * d * d) / 4;
                V = A * t;
                M = V * 1 / 1000 * material;
                Wert = M * 1 / 1000 * preis;

                //Rundung
                d = Math.Round(d, 2);
                p = Math.Round(p, 2);
                h = Math.Round(h, 2);
                da = Math.Round(da, 2);
                ha = Math.Round(ha, 2);
                df = Math.Round(df, 2);
                A = Math.Round(A, 2);
                V = Math.Round(V, 2);
                M = Math.Round(M, 2);
                Wert = Math.Round(Wert, 2);
            }

        }

        public MainWindow()
        {

        }

        public void btn_Bestätigen_Click(object sender, RoutedEventArgs e)
        {
            Außenverzahnung av = new Außenverzahnung();
            switch (CB_Werkstoff.Text)
            {
                case "GJL":
                    av.material = 7.15;
                    av.preis = 0.80;
                    break;

                case "GJS":
                    av.material = 7.1;
                    av.preis = 1.10;
                    break;

                case "S235JR":
                    av.material = 7.85;
                    av.preis = 3.63;
                    break;

                case "Bitte wählen...":
                    break;
            }

            //Eingabeparameter Anzeige
            lb_Werkstoffwahl.Content = CB_Werkstoff.Text;
            lb_Zähne.Content = txt_Zähnezahl.Text;
            lb_Kopfspiele1.Content = CB_Kopfspiel.Text;
            lb_Modul2.Content = txt_Modul.Text;
            lb_Dicke1.Content = txt_Dicke.Text;

            //Eingabechecks
            //Eingabecheck Modul
            string Zahlencheck = txt_Modul.Text;
            if (Zahlenprüfung(Zahlencheck) == true)
            {
                av.m = Convert.ToDouble(txt_Modul.Text);
                if (av.m <= 0)
                {
                    MessageBox.Show("Fehler! Modul kann nur eine positive Zahl betragen.");
                    av.Fehler = 1;
                }
            }
            else
            {
                MessageBox.Show("Fehler! Modul kann nur eine positive Zahl betragen.");
                av.Fehler = 1;
            }

            //Eingabecheck Zähnezahl
            Zahlencheck = txt_Zähnezahl.Text;
            if (Zahlenprüfung(Zahlencheck) == true)
            {
                av.z = Convert.ToDouble(txt_Zähnezahl.Text);
                if (av.z <= 0)
                {
                    MessageBox.Show("Fehler! Zähnezahl kann nur eine positive Ganzzahl ab 5 betragen.");
                    av.Fehler = 1;
                }
            }
            else
            {
                MessageBox.Show("Fehler! Zähnezahl kann nur eine positive Ganzzahl ab 5 betragen.");
                av.Fehler = 1;
            }

            //Eingabecheck Dicke
            Zahlencheck = txt_Dicke.Text;
            if (Zahlenprüfung(Zahlencheck) == true)
            {
                av.t = Convert.ToDouble(txt_Dicke.Text);
                if (av.t <= 0)
                {
                    MessageBox.Show("Fehler! Dicke kann nur eine positive Zahl betragen.");
                    av.Fehler = 1;
                }
            }
            else
            {
                MessageBox.Show("Fehler! Dicke kann nur eine positive Zahl betragen.");
                av.Fehler = 1;
            }

            if (av.Fehler == 0)
            {
                av.Berechnung();
                 Lbl_Zahnhöhe.Content = Convert.ToString(av.h);
                 lbl_Fußkreisdurchmesser.Content = Convert.ToString(av.df);
                 lbl_Teilkreisdurchmesser.Content = Convert.ToString(av.d);
                 lbl_Zahnfußhöhe.Content = Convert.ToString(av.hf);
                 lbl_Zahnkopfhöhe.Content = Convert.ToString(av.ha);
                 lbl_Teilung.Content = Convert.ToString(av.p);
                 lbl_Kopfkreisdurchmesser.Content = Convert.ToString(av.da);
                 lbl_Gewicht.Content = Convert.ToString(av.M);
                 lbl_Preis.Content = Convert.ToString(av.Wert);
            }
            else
            {
                MessageBox.Show("Berechnung konnte nicht durchgeführt werden");
            }


        }



        private void btn_Zurück_Click(object sender, RoutedEventArgs e)
        {
            //Felder leeren
            Lbl_Zahnhöhe.Content = " ";
            lbl_Fußkreisdurchmesser.Content = " ";
            lbl_Teilkreisdurchmesser.Content = " ";
            lbl_Zahnfußhöhe.Content = " ";
            lbl_Zahnkopfhöhe.Content = " ";
            lbl_Teilung.Content = " ";
            lbl_Kopfkreisdurchmesser.Content = " ";
            lbl_Gewicht.Content = " ";
            lbl_Preis.Content = " ";
            lb_Zähne.Content = " ";
            lb_Modul2.Content = " ";
            lb_Kopfspiele1.Content = " ";
            lb_Werkstoffwahl.Content = " ";
            lb_Dicke1.Content = " ";
            txt_Modul.Text = " ";
            txt_Zähnezahl.Text = " ";
            txt_Dicke.Text = " ";

            //ComboButton zurücksetzen
            S235JR.IsSelected = true;
            Kopfspiel167.IsSelected = true;
        }
    }

    


}

      


   




