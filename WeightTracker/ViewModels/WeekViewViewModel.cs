using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using WeightTracker.Models;

namespace WeightTracker.ViewModels
{
    public class WeekViewViewModel : INotifyPropertyChanged
    {
        public string todaysWeight;
        public string TodaysWeight
        {
            get => todaysWeight;
            set
            {
                if(todaysWeight == value)
                {
                    return;
                }
                else
                {
                    todaysWeight = value;
                    OnPropertyChanged(TodaysWeight);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string todaysWeight)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(todaysWeight));
        }
    }
}
