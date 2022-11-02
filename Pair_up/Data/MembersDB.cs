using System;
using SQLite;
using Pair_up.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pair_up.Data
{
    public class MembersDB
    {
        readonly SQLiteAsyncConnection members_db;

        public MembersDB(string connectionString)
        {
            members_db = new SQLiteAsyncConnection(connectionString);

            members_db.CreateTableAsync<MyListModel>().Wait();
        }

        public Task<List<MyListModel>> GetMembersAsync()
        {
            return members_db.Table<MyListModel>().ToListAsync();

        }

        public Task<int> DeleteNoteAsync(MyListModel mylistmodel)
        {
            return members_db.DeleteAsync(mylistmodel); 
        }
    }
}
