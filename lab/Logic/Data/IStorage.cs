using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic
{
    interface IStorage<T> where T: class
    {
        public int Length { get; }

        public string Name { get; }

        public void AddItem(T item);

        public T GetItem(int id);

        public void RemoveItem(int id);
    }
}
