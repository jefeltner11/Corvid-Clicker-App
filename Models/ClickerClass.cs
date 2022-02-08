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
        public string Name { get; set; }
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

        public Clicker(string name)
        {
            this.Name = name;
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
