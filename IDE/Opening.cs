using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IDE
{
    public partial class Opening : Form
    {
        public Opening()
        {
            InitializeComponent();
        }

        private void Opening_Load(object sender, EventArgs e)
        {
            ReadToListBox();
        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            if (lbx_paths.SelectedIndex != -1) //Check if an item was selected (would open that instead)
            {
                string path = lbx_paths.SelectedItem.ToString();

                Form1 txt_Editor = new Form1(path);
                txt_Editor.Show();
                Hide();

                return;
            }

                using (var fbd = new FolderBrowserDialog()) //Let's the user choose a file
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    /*string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");*/

                    InsertPathToList(fbd.SelectedPath); //Inserts the path to the quick file

                    Form1 txt_Editor = new Form1(fbd.SelectedPath);
                    txt_Editor.Show();
                    Hide();
                }
            }
        }

        string quickFilePath = "./quickPath";
        void InsertPathToList(string appenedFile) //Inserts data to the list of all used path (for quick chose)
        {
             
            if(!File.Exists(appenedFile)) //Creates the file in case it doesn't exists
            {
                var f = File.Create(quickFilePath);
                f.Close();
            }

            File.AppendAllText(quickFilePath, appenedFile);
        }

        public void ReadToListBox() //Reads the quick file to the list box
        {
            var file = File.ReadAllLines(quickFilePath);

            foreach (var line in file)
            {
                lbx_paths.Items.Add(line);
            }
        }

        private void Opening_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
