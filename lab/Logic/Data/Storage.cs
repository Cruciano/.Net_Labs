using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Logic
{
    class Storage<T> : IStorage<T> where T: class
    {
        protected string _name;
        protected List<T> _list;

        public Storage(string name)
        {
            this._name = name;
            _list = new();
        }

        public int Length
        {
            get { return _list.Count; }
        }

        public string Name
        {
            get { return _name; }
        }

        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public T GetItem(int id)
        {
            if (id > this.Length || id < 0)
                throw new ArgumentException("Id must be above zero and less than lenght");

            return _list[id];
        }

        public void RemoveItem(int id)
        {
            if (id > this.Length || id < 0)
                throw new ArgumentException("Id must be above zero and less than lenght");

            _list.RemoveAt(id);
        }
    }
}
