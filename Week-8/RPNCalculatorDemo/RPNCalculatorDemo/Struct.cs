using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorDemo
{
    struct Entry
    {
        public EntryType Type { get; }
        public int? Value { get; }
        public Entry(EntryType type, int? value = null)
        {
            Type = type; Value = value;
        }
       
    }

}
