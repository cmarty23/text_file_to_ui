using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    internal class Field
    {
        public string name;
        public string value;

        public Field()
        {

        }
        public Field(string Name, string Value)
        {
            name = Name;
            value = Value;
        }
    }
}
