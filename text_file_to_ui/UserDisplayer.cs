using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    internal class UserDisplayer
    {
        public void DisplayUserInfo(User user, UserInfoForm info)
        {
            foreach (var field in user.fieldList)
            {
                DisplayField(field, info);
            }
        }
        private void DisplayField(Field field, UserInfoForm info)
        {
            switch (field.name) 
            {
                case "Ime":
                case "Name":
                    info.name.value = field.value;
                    break;
                case "Surname":
                    info.name.value = info.name.value + " " + field.value;
                    break;
                case "Year of birth":
                    info.yearOfBirth.value = field.value;
                    break;
                case "City of origin":
                    info.city.value = field.value;
                    break;
                case "Faculty":
                    info.faculty.value = field.value;
                    break;
                case "Role":
                    info.role.value = field.value;
                    break;
                case "Favorite course":
                case "Department":
                    info.specificAttribute.value = field.value;
                    info.specificAttribute.name = field.name;
                    break;

            }
        }

    }
}
