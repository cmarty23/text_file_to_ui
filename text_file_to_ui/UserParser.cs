using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui
{
    internal class UserParser
    {

        public User parseUser(string[] fileContent)
        {
            List<string> content = fileContent.ToList();
            content.RemoveAt(-1);

            User user = new User();

            foreach (var (line, i) in content.Select((line, i) => (line, i)))
            {
                Field field = new Field();
                field.Name = getFieldName(line);
                field.Value = getFieldValue(line);

                user.fieldList.Add(field);
            }

            return user;
        }

        private string getFieldName(string line) 
        {
            return line.Split('=')[0];
        } 
        private string getFieldValue(string line)
        {
            return line.Split('=')[1];
        }
    }
}
