using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using MvvmHelpers.Commands;
using MvvmHelpers;

namespace WeightTracker.ViewModels
{
    //ViewModels  are used to create properties or commands that the view (which is what the user sees) can bind things to.
    public class EnterWeightViewModel : ObservableObject
    {
        
        public EnterWeightViewModel()
        {
            UpdateWeight = new Command(ChangeWeight);
        }

        public ICommand UpdateWeight { get; }

        void ChangeWeight()
        {
            EnteredWeight = "Hello World";
            OnPropertyChanged(EnteredWeight);
        }

        public string enterWeight;
        public string EnteredWeight
        {
            get => enterWeight;
            set => SetProperty(ref enterWeight, value);
           /* {
                if (enterWeight == value)
                {
                    return;
                }
                else
                {
                    enterWeight = value;
                    OnPropertyChanged(nameof(EnteredWeight));
                }
            }*/
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string enterWeight)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(enterWeight));
        }
    }
}
