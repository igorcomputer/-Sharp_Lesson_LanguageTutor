using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageTutor
{
    class Tutor
    {
        private Dictionary<string, string> _dic = new Dictionary<string, string>();

        public void AddWord(string eng, string rus)
        {
            _dic.Add(eng, rus);
        }

        public bool CheckWord(string eng, string rus)
        {
            var answer = _dic[eng];
            return answer == rus;
        }
    }
}
