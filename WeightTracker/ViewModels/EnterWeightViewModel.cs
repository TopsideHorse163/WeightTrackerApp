using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;

namespace WeightTracker.ViewModels
{
    //ViewModels  are used to create properties or commands that the view (which is what the user sees) can bind things to.
    public class EnterWeightViewModel : INotifyPropertyChanged
    {
        public string enterWeight;
        public string EnteredWeight
        {
            get => enterWeight;
            set
            {
                enterWeight = value;
                OnPropertyChanged(EnteredWeight);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string enterWeight)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(enterWeight));
        }
    }
}
