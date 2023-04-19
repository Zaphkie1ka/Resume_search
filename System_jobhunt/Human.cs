using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_jobhunt
{
    class Human
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Human(string name)
        {
            _name = name;
        }
    }
}
