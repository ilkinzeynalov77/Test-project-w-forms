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

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Directory.GetCurrentDirectory());
            string path = Directory.GetCurrentDirectory() + @"\..\..\..\..\" +textbox.Text + ".txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            if(!String.IsNullOrEmpty(richtextbox.Text))
               streamWriter.WriteLine(richtextbox.Text);
            streamWriter.Close();

            MessageBox.Show("Fayl ugurla yaradildi", "Ugurlu emeliyyat", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\..\..\..\..\" + textbox.Text + ".txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
            MessageBox.Show("Fayl ugurla silindi", "Ugurlu emeliyyat", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
