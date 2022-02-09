using System.IO;

namespace IDE
{
    partial class Form1 : Form
    {
        string mainDir;
        public Form1(string directory)
        {
            InitializeComponent();

            mainDir = directory;
            DataToTextBox(mainDir);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void DataToTextBox(string dir)
        {
            lbx_files.Items.Clear();

            string[] dirs = Directory.GetDirectories(dir);
            string[] files = Directory.GetFiles(dir);

            List<string> dirsAndFiles = new List<string>(); //Creates a list of directories and files
            dirsAndFiles.AddRange(dirs);
            dirsAndFiles.AddRange(files);

            for(int i = 0; i < dirsAndFiles.Count; i++) //Gets the name from the path
            {
                dirsAndFiles[i] = GetNameFromPath(dirsAndFiles[i]);
            }

            dirsAndFiles.Sort(); //Sorts the list
            
            foreach(string file in dirsAndFiles) //Adds to the list box
            {
                lbx_files.Items.Add(file);
            }
        }

        string GetNameFromPath(string path) //Gets the path and returns only the name
        {
            string[] delimiterChars = { //List of symbols that it would split at
                            "/",
                            "//",
                            "\\",
                            @"\"
                          };

            string[] parts = path.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            return parts[parts.Length - 1]; //Only returns the name (final part of the path)
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbx_files_SelectedIndexChanged(object sender, EventArgs e) //Selecting a file
        {
            img_file.Visible = false; //In case it's a txt file
            txt_text.Visible = true;

            string file = lbx_files.SelectedItem.ToString();
            string path = mainDir + "/" + file;

            try
            {
                string text = File.ReadAllText(path);

                txt_text.Text = text;
            }
            catch //In case that the file is unreadable
            {
                OpenImg(path); //Maybe it's a picture idk
            }
            //FileInfo fileInfo = new FileInfo(path);
            //string extention = fileInfo.Extension; //Gets the type of the file
        }

        void OpenImg(string path) //Open a file as an image
        {
            try
            {
                img_file.Image = Image.FromFile(path);
                img_file.Visible = true;
                txt_text.Visible = false;
            }
            catch
            {
                MessageBox.Show("Unable to open the file, please try another file", "Error");
            }
        }
    }
}