using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClickerApp.Models
{
    public class Clicker : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _clickCount = 0;
        private int _cps = 0;
        private int _baitCount = 0;
        private int _baitCost = 10;
        private int _cageCount = 0;
        private int _cageCost = 100;
        private int _aviaryCount = 0;
        private int _aviaryCost = 750;
        private int _magnetCount = 0;
        private int _magnetCost = 5000;
        private int _droneCount = 0;
        private int _droneCost = 25000;
        private int _empCount = 0;
        private int _empCost = 100000;
        private int _flareCount = 0;
        private int _flareCost = 500000;

        public int ClickCount
        {
            get { return _clickCount; }
            set
            {
                _clickCount = value;
                OnPropertyChanged();
            }
        }
        public int cpsTracker
        {
            get { return _cps;  }
            set
            {
                _cps = value;
                OnPropertyChanged();
            }
        }
        public int baitCount
        {
            get { return _baitCount; }
            set
            {
                _baitCount = value;
                OnPropertyChanged();
            }
        }
        public int baitCost
        {
            get { return _baitCost; }
            set
            {
                _baitCost = value;
                OnPropertyChanged();
            }
        }
        public int cageCount
        {
            get { return _cageCount; }
            set
            {
                _cageCount = value;
                OnPropertyChanged();
            }
        }
        public int cageCost
        {
            get { return _cageCost; }
            set
            {
                _cageCost = value;
                OnPropertyChanged();
            }
        }
        public int aviaryCount
        {
            get { return _aviaryCount; }
            set
            {
                _aviaryCount = value;
                OnPropertyChanged();
            }
        }
        public int aviaryCost
        {
            get { return _aviaryCost; }
            set
            {
                _aviaryCost = value;
                OnPropertyChanged();
            }
        }
        public int magnetCount
        {
            get { return _magnetCount; }
            set
            {
                _magnetCount = value;
                OnPropertyChanged();
            }
        }
        public int magnetCost
        {
            get { return _magnetCost; }
            set
            {
                _magnetCost = value;
                OnPropertyChanged();
            }
        }
        public int droneCount
        {
            get { return _droneCount; }
            set
            {
                _droneCount = value;
                OnPropertyChanged();
            }
        }
        public int droneCost
        {
            get { return _droneCost; }
            set
            {
                _droneCost = value;
                OnPropertyChanged();
            }
        }
        public int empCount
        {
            get { return _empCount; }
            set
            {
                _empCount = value;
                OnPropertyChanged();
            }
        }
        public int empCost
        {
            get { return _empCost; }
            set
            {
                _empCost = value;
                OnPropertyChanged();
            }
        }
        public int flareCount
        {
            get { return _flareCount; }
            set
            {
                _flareCount = value;
                OnPropertyChanged();
            }
        }
        public int flareCost
        {
            get { return _flareCost; }
            set
            {
                _flareCost = value;
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
