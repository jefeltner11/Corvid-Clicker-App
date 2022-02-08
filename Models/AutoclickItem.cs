using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClickerApp.Models;

namespace ClickerApp.Models
{
    public class AutoclickItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _owned = -1;
        private int _cost = 0;
        public string Name { get; set;}
        public int InitialCost { get; set;}
        public int Factor { get; set;}
        public int Owned
        {
            get { return _owned; }
            set
            {
                _owned = value;
                OnPropertyChanged();
            }
        }
        public int Cost
        {
            get { return _cost; }
            set
            {
                _cost = value;
                OnPropertyChanged();
            }
        }
        public AutoclickItem(string name, int initialCost, int factor)
        {
            this.Name = name;
            this.Owned = 0;
            this.InitialCost = initialCost;
            this.Cost = initialCost;
            this.Factor = factor;
        }
        public Object BuyItem(Clicker clicker)
        {
            if(clicker.ClickCount >= this.Cost)
            {
                this.Owned += 1;
                clicker.ClickCount -= this.Cost;
                IncreaseCost();
                IncreaseCPS(clicker);
                OnPropertyChanged();
            }
            return clicker;
        }
        public void IncreaseCost()
        {
            this.Cost = (int)(this.InitialCost * Math.Pow(1.15, Convert.ToDouble(this.Owned))); // This formula has been borrowed
            OnPropertyChanged();                                                                // from Cookie Clicker temporarily!
        }
        public void IncreaseCPS(Clicker clicker)
        {
            clicker.cpsTracker += this.Factor;
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
