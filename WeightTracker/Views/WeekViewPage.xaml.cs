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
        EnterWeightViewModel enterWeightViewModel = new EnterWeightViewModel();
        WeekViewViewModel weekViewViewModel = new WeekViewViewModel();

        public WeekView()
        {
        List<Weight> myList = new List<Weight>
        {
           
            
        };
            InitializeComponent();
            myListView.ItemsSource = myList;
        }
    }
}