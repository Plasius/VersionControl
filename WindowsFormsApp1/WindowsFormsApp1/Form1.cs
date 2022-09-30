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
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();

            label1.Text = Resource1.FullName; 
            button1.Text = Resource1.Add;
            button2.Text = Resource1.File;
            button3.Text = Resource1.Delete;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    
                    // Code to write the stream goes here.
                    var sw = new StreamWriter(myStream, new UnicodeEncoding());
                    try
                    {
                        foreach (var user in users)
                        {
                            sw.Write(user.ID);
                            sw.Write(user.FullName);
                            sw.Write("\n");
                        }

                        sw.Flush();
                    }
                    finally
                    {
                        sw.Dispose();
                    }
                    myStream.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
