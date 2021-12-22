using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using WeightTracker.Models;


namespace WeightTracker.Services
{
    public static class TrackerService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;
            // Get an absolute path to the database file
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Weight>(); 
        }

        public static async Task SetWeight(string weight)
        {
            await Init();
            var pounds = new Weight()
            {
                TodaysWeight = weight,
                TodaysDate = DateTime.Now.ToShortDateString()
            };
            await db.InsertAsync(pounds);
        }
        public static async Task<IEnumerable<Weight>> GetWeight()
        {
            await Init();
            var lbs = await db.Table<Weight>().ToListAsync();
            return lbs;
           
        }
    }
}
