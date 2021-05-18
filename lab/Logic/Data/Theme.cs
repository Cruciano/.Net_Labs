using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic
{
    class Theme : Storage<Test>
    {
        public Theme(string name) : base(name)
        {

        }

        public IEnumerable<string> GetNames()
        {
            List<string> names = new();

            foreach (var el in _list)
            {
                names.Add(el.Name);
            }

            return names;
        }
    }
}
