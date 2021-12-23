using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using WeightTracker.Models;
using MvvmHelpers;

namespace WeightTracker.ViewModels
{
    public class WeekViewViewModel : ObservableObject
    {
        public WeekViewViewModel()
        {

        }
        
        
        
        
        public string todaysWeight;
        public string TodaysWeight
        {
            get => todaysWeight;
            set => SetProperty(ref todaysWeight, value);
        }

    }
}
