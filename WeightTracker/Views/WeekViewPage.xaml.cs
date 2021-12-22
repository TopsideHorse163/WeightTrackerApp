using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightTracker.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeightTracker.Views;
using WeightTracker.ViewModels;


namespace WeightTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeekView : ContentPage
    {
        public WeekView()
        {
        List<Weight> myList = new List<Weight>
        {
           //  new Weight{TodaysDate = DateTime.Today.ToShortDateString(), TodaysWeight = EnterWeightViewModel.EnteredWeight},
             //new Weight{TodaysDate = DateTime.Today.ToShortDateString(), TodaysWeight = EnterWeightViewModel.EnteredWeight},
        };
            InitializeComponent();
            myListView.ItemsSource = myList;
        }
    }
}