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

            members_db.CreateTableAsync<People>().Wait();
        }

        public Task<List<People>> GetMembersAsync()
        {
            return members_db.Table<People>().ToListAsync();

        }

        public Task<int> DeleteNoteAsync(People mylistmodel)
        {
            return members_db.DeleteAsync(mylistmodel); 
        }
    }
}
