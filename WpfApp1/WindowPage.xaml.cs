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
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowPage.xaml
    /// </summary>
    public partial class WindowPage : Window
    {
        public WindowPage()
        {
            InitializeComponent();
            DoubleAnimation WA = new DoubleAnimation();
            WA.From = 100;
            WA.To = 180;
            WA.Duration = TimeSpan.FromSeconds(2);
            WA.RepeatBehavior = RepeatBehavior.Forever;
            WA.AutoReverse = true;
            Klubnika.BeginAnimation(WidthProperty, WA);

            DoubleAnimation WH = new DoubleAnimation();
            WH.From = 100;
            WH.To = 180;
            WH.Duration = TimeSpan.FromSeconds(2);
            WH.RepeatBehavior = RepeatBehavior.Forever;
            WH.AutoReverse = true;
            Klubnika.BeginAnimation(HeightProperty, WH);

            DoubleAnimation FS = new DoubleAnimation();
            FS.From = 16;
            FS.To = 24;
            FS.Duration = TimeSpan.FromSeconds(2);
            FS.RepeatBehavior = RepeatBehavior.Forever;
            FS.AutoReverse = true;
            tb1.BeginAnimation(FontSizeProperty, FS);

            DoubleAnimation FSS = new DoubleAnimation();
            FSS.From = 16;
            FSS.To = 24;
            FSS.Duration = TimeSpan.FromSeconds(2);
            FSS.RepeatBehavior = RepeatBehavior.Forever;
            FSS.AutoReverse = true;
            tb2.BeginAnimation(FontSizeProperty, FSS);

            DoubleAnimation FSFS = new DoubleAnimation();
            FSFS.From = 16;
            FSFS.To = 24;
            FSFS.Duration = TimeSpan.FromSeconds(2);
            FSFS.RepeatBehavior = RepeatBehavior.Forever;
            FSFS.AutoReverse = true;
            tb3.BeginAnimation(FontSizeProperty, FSFS);

            ThicknessAnimation MA = new ThicknessAnimation();
            MA.From = new Thickness(0, 0, 0, 0);
            MA.To = new Thickness(0, 25, 0, 0);
            MA.Duration = TimeSpan.FromSeconds(2);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            tb1.BeginAnimation(MarginProperty, MA);

            ColorAnimation BA = new ColorAnimation();
            ColorConverter CC = new ColorConverter();
            Color Cstart = (Color)CC.ConvertFrom("#00ff04");
            bor.BorderBrush = new SolidColorBrush(Cstart);
            BA.From = Cstart;
            BA.To = (Color)CC.ConvertFrom("#ff00ee");
            BA.Duration = TimeSpan.FromSeconds(2);
            BA.AutoReverse = true;
            bor.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, BA);

            //ColorAnimation BB = new ColorAnimation();
            //ColorConverter CB = new ColorConverter();
            //Color Bstart = (Color)CB.ConvertFrom("#ff00ee");
            //Btn4.Foreground = new SolidColorBrush(Cstart);
            //BB.From = Bstart;
            //BB.To = (Color)CB.ConvertFrom("#fffb00");
            //BB.Duration = TimeSpan.FromSeconds(4);
            //BB.AutoReverse = true;
            //Btn4.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, BB);
        }
    }
}
