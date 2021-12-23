using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using MvvmHelpers.Commands;
using MvvmHelpers;
using System.Threading.Tasks;
using WeightTracker.Services;

namespace WeightTracker.ViewModels
{
    //ViewModels  are used to create properties or commands that the view (which is what the user sees) can bind things to.
    public class EnterWeightViewModel : ObservableObject
    {
        TrackerService tracker = new TrackerService();
        public EnterWeightViewModel()
        {
            UpdateWeight = new Command(SetWeight);
            AddCommand = new AsyncCommand();
            Person = new ObservableRangeCollection<string>();
        }

        ObservableRangeCollection<string> Person { get; }

        //Commands ------------------------------------------------------------------------------------------------------

        public AsyncCommand AddCommand { get; }

        public ICommand UpdateWeight { get; }

        void SetWeight()
        {
            EnteredWeight = "Hello World";
            OnPropertyChanged(EnteredWeight);
        }

//Tasks ---------------------------------------------------------------------------------------------------------

        async Task Add(string weight)
        {
            await tracker.SetWeightDB(weight);
        }


//Bindable Properties -------------------------------------------------------------------------------------------



        public string todaysDate = DateTime.Today.ToShortDateString();
        public string TodaysDate
        {
            get => todaysDate;
            set => SetProperty(ref todaysDate, value);
        }

        public string enterWeight;
        public string EnteredWeight
        {
            get => enterWeight;
            set => SetProperty(ref enterWeight, value);
           
        }
    }
}
