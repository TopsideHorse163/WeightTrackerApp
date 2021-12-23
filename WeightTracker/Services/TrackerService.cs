using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using WeightTracker.Models;
using Xamarin.Essentials;

namespace WeightTracker.Services
{
    public class TrackerService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            {
                return;
            }
            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Weight>();
        }

        public async Task SetWeightDB(string weight)
        {
            await Init();
            var pounds = new Weight()
            {
                TodaysWeight = weight,
                TodaysDate = DateTime.Now.ToShortDateString()
            };
            await db.InsertAsync(pounds);
        }
        public async Task<IEnumerable<Weight>> GetWeight()
        {
            await Init();
            var lbs = await db.Table<Weight>().ToListAsync();
            return lbs;

        }
    }
}
