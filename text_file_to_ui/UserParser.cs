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
            content.RemoveAt(content.Count -1);

            User user = new User();

            foreach (var (line, i) in content.Select((line, i) => (line, i)))
            {
                
                string name = getFieldName(line);
                string value = getFieldValue(line);

               

                user.fieldList.Add(new Field(name, value));
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
