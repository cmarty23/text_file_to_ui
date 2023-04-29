using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    internal class UserDisplayer
    {
        public void displayUserInfo(User user, UserInfoForm info)
        {
            foreach (var (field, i) in user.fieldList.Select((field, i) => (field, i)))
            {
                displayField(field, info);
            }
        }
        private void displayField(Field field, UserInfoForm info)
        {


        }

    }
}
