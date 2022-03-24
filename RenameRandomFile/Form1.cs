using System;
using System.Windows.Forms;
using System.IO;

namespace RenameRandomFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RUNBUTTON.Enabled = false;

            minLetterTextBox.Text = "100";
            maxLetterTextBox.Text = "100000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void pathBTN_Click(object sender, EventArgs e)
        {
            //с помощью диалога выбираем папку с файлами
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathTextBox.Text = fbd.SelectedPath.ToString();
                RUNBUTTON.Enabled = true;
            }
        }

        private void Run()
        {
            try
            {
                Random rand = new Random();
                int temp;
                temp = rand.Next(Int32.Parse(minLetterTextBox.Text), Int32.Parse(maxLetterTextBox.Text));

                //Получить все файлы в папке
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                int ind = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    //поиск индекса последнего слеша
                    ind = files[i].LastIndexOf('\\');
                    //переименование
                    File.Move(files[i], files[i].Remove(ind + 1) + i + temp + ".jpg");
                }
            }
            catch
            {
                MessageBox.Show("Error. File already reneme", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minLetterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void maxLetterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
