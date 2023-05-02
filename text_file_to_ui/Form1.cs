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
        UserInfoForm info;
        UserFileReader reader;
        UserParser parser;
        User user;
        UserDisplayer display;
        public Form1()
        {
            InitializeComponent();
            reader = new UserFileReader();
            parser = new UserParser();
            info = new UserInfoForm();
            display = new UserDisplayer();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTextContent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                reader.filePath = openFileDialog1.FileName;
                reader.ReadUserFile();
                user = parser.ParseUser(reader.fileContent);
                display.DisplayUserInfo(user, info);


                UpdateTextContent();

            }
        }
        private void UpdateTextContent()
        {
            label1.Text = info.name.name.ToString() + ":";
            label2.Text = info.yearOfBirth.name.ToString() + ":";
            label3.Text = info.city.name.ToString() + ":";
            label4.Text = info.faculty.name.ToString() + ":";
            label5.Text = info.role.name.ToString() + ":";
            label6.Text = info.specificAttribute.name.ToString() + ":";

            textBox1.Text = info.name.value.ToString();
            textBox2.Text = info.yearOfBirth.value.ToString();
            textBox3.Text = info.city.value.ToString();
            textBox4.Text = info.faculty.value.ToString();
            textBox5.Text = info.role.value.ToString();
            textBox6.Text = info.specificAttribute.value.ToString();
        }


    }
}
