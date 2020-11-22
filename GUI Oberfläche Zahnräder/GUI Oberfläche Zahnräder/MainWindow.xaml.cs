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
        
        public MainWindow()
        {
            InitializeComponent();
            rtb_S235JR.Visibility = Visibility.Hidden;
            rtb_EN_GJS.Visibility = Visibility.Hidden;
            rtb_EN_GJL.Visibility = Visibility.Hidden;
            lb_Werkstoffwahl.Visibility = Visibility.Hidden;

            rtb_Standard.Visibility = Visibility.Hidden;
            rtb_0_1.Visibility = Visibility.Hidden;
            rtb_0_3.Visibility = Visibility.Hidden;
            lb_Kopfspiel.Visibility = Visibility.Hidden;

            Im_GeradZahnrad.Visibility = Visibility.Hidden;
            Im_Innenzahnrad.Visibility = Visibility.Hidden;
            Im_Kegelrad.Visibility = Visibility.Hidden;
            Im_SchrägZahnrad.Visibility = Visibility.Hidden;

            txt_Breite.Visibility = Visibility.Hidden;
            txt_Modul.Visibility = Visibility.Hidden;
            txt_Teilkreis.Visibility = Visibility.Hidden;
            txt_Zähne.Visibility = Visibility.Hidden;

            lb_Breite.Visibility = Visibility.Hidden;
            lb_Modul.Visibility = Visibility.Hidden;
            lb_Teilkreisdurchmesser.Visibility = Visibility.Hidden;
            lb_Zähnezahl.Visibility = Visibility.Hidden;

            
            
        }

      

       

        
    }
   



}
