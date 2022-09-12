using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class Player
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value.ToUpper();
            }
        }
        
        public int Level { get; set; }

        public bool Alive { get; set; }
    }
}
