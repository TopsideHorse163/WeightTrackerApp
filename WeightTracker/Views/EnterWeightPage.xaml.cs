using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeightTracker.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterWeight : ContentPage
    {
        public EnterWeight()
        {
            InitializeComponent();
           
            BindingContext = this;
            LabelName.Text = DateTime.Today.ToShortDateString();

        }

       

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Entry_Weight.Text = "Hello World";
            
        }
    }
}