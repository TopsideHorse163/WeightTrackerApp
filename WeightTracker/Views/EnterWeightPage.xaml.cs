using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeightTracker.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeightTracker.Views;
namespace WeightTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterWeight : ContentPage
    {
        WeekViewViewModel weekViewViewModel = new WeekViewViewModel();
        EnterWeightViewModel ewvm = new EnterWeightViewModel();
        public EnterWeight()
        {
            InitializeComponent();

            BindingContext = new EnterWeightViewModel();
            LabelName.Text = DateTime.Today.ToShortDateString();

        }
        public string date = DateTime.Today.ToShortDateString();
       

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            ewvm.EnteredWeight = EntryWeight.Text;
        }

        
    }
}