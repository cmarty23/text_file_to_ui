using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text_file_to_ui
{
    internal class UserFileReader
    {
        public string filePath;
        public string[] fileContent;

        public void readUserFile()
        {
            fileContent = File.ReadAllLines(filePath);
            incrementFileOpenCounter();
        }
        private void incrementFileOpenCounter()
        {
            string lastLine = fileContent[fileContent.Length - 1];
            int idx = lastLine.LastIndexOf('=');

            if (idx == -1)
            {
                return; //TODO catch error
            }
            int newCount = int.Parse(lastLine.Substring(idx + 1))+1;

            fileContent[fileContent.Length - 1] = lastLine.Substring(0, idx) + newCount.ToString();

            File.WriteAllLines(filePath, fileContent);
        }
    }
}
