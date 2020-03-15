using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENIKochbuch.Models.DB
{
    interface IRepoEntry
    {
        void Open();
        void Close();
        bool Insert(Entry entry);
        bool Delete(int id);
        bool UpdateEntry(int id, Entry updateEntry);
        List<Entry> allrecipes();
        Entry onerecipe(int id);
    }
}
