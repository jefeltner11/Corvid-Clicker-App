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
        AutoclickItem Bait = new AutoclickItem("Bait", 10, 1);
        AutoclickItem Cage = new AutoclickItem("Cage", 100, 5);
        AutoclickItem Aviary = new AutoclickItem("Aviary", 750, 20);
        AutoclickItem Magnet = new AutoclickItem("Magnet", 5000, 50);
        AutoclickItem Drone = new AutoclickItem("Drone", 25000, 350);
        AutoclickItem EMP = new AutoclickItem("EMP", 100000, 1500);
        AutoclickItem Flare = new AutoclickItem("Flare", 500000, 7500);
        Clicker corvidClicker = new Clicker("Corvid Clicker");
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = corvidClicker;
            buyBait.DataContext = Bait;
            currentBait.DataContext = Bait;
            buyCage.DataContext = Cage;
            currentCage.DataContext = Cage;
            buyAviary.DataContext = Aviary;
            currentAviary.DataContext = Aviary;
            buyMagnet.DataContext = Magnet;
            currentMagnet.DataContext = Magnet;
            buyDrone.DataContext = Drone;
            currentDrone.DataContext = Drone;
            buyEmp.DataContext = EMP;
            currentEmp.DataContext = EMP;
            buyFlare.DataContext = Flare;
            currentFlare.DataContext = Flare;
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
            Bait.BuyItem(corvidClicker);
        }

        private void buyCageButton_Click(object sender, RoutedEventArgs e)
        {
            Cage.BuyItem(corvidClicker);
        }

        private void buyAviaryButton_Click(object sender, RoutedEventArgs e)
        {
            Aviary.BuyItem(corvidClicker);
        }

        private void buyMagnetButton_Click(object sender, RoutedEventArgs e)
        {
            Magnet.BuyItem(corvidClicker);
        }

        private void buyDroneButton_Click(object sender, RoutedEventArgs e)
        {
            Drone.BuyItem(corvidClicker);
        }

        private void buyEmpButton_Click(object sender, RoutedEventArgs e)
        {
            EMP.BuyItem(corvidClicker);
        }

        private void buyFlareButton_Click(object sender, RoutedEventArgs e)
        {
            Flare.BuyItem(corvidClicker);
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
