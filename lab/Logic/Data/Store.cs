using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Logic
{
    class Store
    {
        private List<Theme> _themes;

        public Store()
        {
            _themes = new();
            FillList();
        }

        public IEnumerable<string> GetThemeNames()
        {
            List<string> names = new();

            foreach(var el in _themes)
            {
                names.Add(el.Name);
            }

            return names;
        }

        public IEnumerable<string> GetTestNames(int themeId)
        {
            if (themeId > _themes.Count || themeId < 0)
                throw new ArgumentException("Id must be above zero and less than lenght");

            return _themes[themeId].GetNames();
        }

        public Test GetTest(int themeId, int testId)
        {
            if (themeId > _themes.Count || themeId < 0)
                throw new ArgumentException("Id must be above zero and less than lenght");

            return _themes[themeId].GetItem(testId);
        }

        private void FillList()
        {
            Test test11 = new("UniqueTest11");
            test11.AddItem(new("Question", new string[3] { "0", "1", "0" }, 1, 5));
            test11.AddItem(new("Question", new string[3] { "1", "0", "0" }, 0, 5));

            Test test12 = new("UniqueTest12");
            test12.AddItem(new("Question", new string[3] { "1", "0", "0" }, 0, 3));
            test12.AddItem(new("Question", new string[3] { "1", "0", "0" }, 0, 5));

            Test test21 = new("UniqueTest21");
            test21.AddItem(new("Question", new string[3] { "0", "0", "1" }, 2, 7));
            test21.AddItem(new("Question", new string[3] { "0", "1", "0" }, 1, 3));

            Test test22 = new("UniqueTest22");
            test22.AddItem(new("Question", new string[3] { "0", "1", "0" }, 1, 2));
            test22.AddItem(new("Question", new string[3] { "0", "0", "1" }, 2, 4));

            Theme theme1 = new("theme1");
            theme1.AddItem(test11);
            theme1.AddItem(test12);

            Theme theme2 = new("theme2");
            theme2.AddItem(test21);
            theme2.AddItem(test22);


            _themes.Add(theme1);
            _themes.Add(theme2);
        }
    }
}
