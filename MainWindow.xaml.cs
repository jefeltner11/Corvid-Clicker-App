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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClickerApp.Models;
using System.Timers;

namespace ClickerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Clicker corvidClicker = new Clicker();
        Clicker ravenClicker = new Clicker();
        private static System.Timers.Timer aTimer;
        

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = corvidClicker;
            SetTimer();
        }


        private void SetTimer()
        {
            Timer aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            corvidClicker.ClickCount += corvidClicker.cpsTracker;
        }
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            corvidClicker.ClickCount++;
        }


        private void buyBaitButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.baitCost)
            {
                corvidClicker.ClickCount -= corvidClicker.baitCost;
                corvidClicker.baitCount += 1;
                corvidClicker.baitCost += 5 * corvidClicker.baitCount;
                corvidClicker.cpsTracker += 1;
            }
            
        }

        private void buyCageButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.cageCost)
            {
                corvidClicker.ClickCount -= corvidClicker.cageCost;
                corvidClicker.cageCount += 1;
                corvidClicker.cageCost += 50 * corvidClicker.cageCount;
                corvidClicker.cpsTracker += 5;
            }
        }

        private void buyAviaryButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.aviaryCost)
            {
                corvidClicker.ClickCount -= corvidClicker.aviaryCost;
                corvidClicker.aviaryCount += 1;
                corvidClicker.aviaryCost += 250 * corvidClicker.aviaryCount;
                corvidClicker.cpsTracker += 20;
            }
        }

        private void buyMagnetButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.magnetCost)
            {
                corvidClicker.ClickCount -= corvidClicker.magnetCost;
                corvidClicker.magnetCount += 1;
                corvidClicker.magnetCost += 1000 * corvidClicker.magnetCount;
                corvidClicker.cpsTracker += 50;
            }
        }

        private void buyDroneButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.droneCost)
            {
                corvidClicker.ClickCount -= corvidClicker.droneCost;
                corvidClicker.droneCount += 1;
                corvidClicker.droneCost += 10000 * corvidClicker.droneCount;
                corvidClicker.cpsTracker += 350;
            }
        }

        private void buyEmpButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.empCost)
            {
                corvidClicker.ClickCount -= corvidClicker.empCost;
                corvidClicker.empCount += 1;
                corvidClicker.empCost += 50000 * corvidClicker.empCount;
                corvidClicker.cpsTracker += 1500;
            }
        }

        private void buyFlareButton_Click(object sender, RoutedEventArgs e)
        {
            if (corvidClicker.ClickCount >= corvidClicker.flareCost)
            {
                corvidClicker.ClickCount -= corvidClicker.flareCost;
                corvidClicker.flareCount += 1;
                corvidClicker.flareCost += 250000 * corvidClicker.flareCount;
                corvidClicker.cpsTracker += 7500;
            }
        }

        private void imageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            imageButton.BorderBrush = Brushes.Black;
            crowImage.Height += 10;
            crowImage.Width += 10;
        }

        private void imageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            imageButton.BorderBrush = Brushes.Transparent;
            crowImage.Height -= 10;
            crowImage.Width -= 10;
        }

        private void imageButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            corvidClicker.ClickCount += 1;
            imageButton.Height -= 10;
            imageButton.Width -= 10;
            crowImage.Height -= 10;
            crowImage.Width -= 10;
        }

        private void imageButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            imageButton.Height += 10;
            imageButton.Width += 10;
            crowImage.Height += 10;
            crowImage.Width += 10;
        }
    }
}
