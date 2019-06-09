using CarInfo.Interfaces;
using CarInfo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace CarInfo.Data
{
    public class LocalDatabase
    {
        private readonly SQLiteAsyncConnection database;
        public LocalDatabase (string path)
        {
            database = new SQLiteAsyncConnection(path);
            database.CreateTableAsync<Car>().Wait();
            database.CreateTableAsync<Route>().Wait();
            database.CreateTableAsync<Fuel>().Wait();
        }
        
        public async Task<List<T>> GetAll<T>() where T : class, new()
        {
            return await database.Table<T>().ToListAsync();
        }
        public async Task<int> SaveItem<T>(T item) where T : class, ISqlite, new()
        {
            var result = await database.UpdateAsync(item);

            if (result == 0)
            {
                result = await database.InsertAsync(item);
            }

            return result;
        }
        public async Task<int> DeleteItem<T>(T item) where T : class, ISqlite, new()
        {
            return await database.DeleteAsync(item);
        }
    }
}
