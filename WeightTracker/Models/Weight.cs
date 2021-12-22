using System;
using SQLite;
using Xamarin.Forms;

namespace WeightTracker.Models
{
    //This is a non-visual class that is used to encapsulate the apps data. That is why the SQLite stuff is there below
    public class Weight : BindableObject
    {

        [PrimaryKey, AutoIncrement]
        public string TodaysDate { get; set; }
        public string TodaysWeight { get; set; }
    
    }
}