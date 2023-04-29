using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_file_to_ui
{
    public partial class Form1 : Form
    {
        UserInfoForm userInfoForm;
        UserFileReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                reader.filePath = openFileDialog1.FileName;
                reader.readUserFile();
            }
        }
    }
}
