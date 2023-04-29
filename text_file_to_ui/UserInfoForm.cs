using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    internal class UserInfoForm
    {
        public Field name = new Field("Full Name");
        public Field yearOfBirth = new Field("Year Of Birth");
        public Field city = new Field("City");
        public Field faculty = new Field("Faculty");
        public Field role = new Field("Role");
        public Field specificAttribute = new Field("[role specific attribute]");
    }
}
