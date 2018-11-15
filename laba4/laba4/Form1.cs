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

namespace laba4
{
    public partial class MainForm : Form
    {
        StreamReader streamReader;
        string fileName;
        int count = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            streamReader = new StreamReader(openFileDialog.FileName);
            doCounting();
            fileName = openFileDialog.FileName;
        }
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog.FileName, count.ToString());
        }
        private void doCounting()
        {
            try
            {
                int[] arrayInt = streamReader.ReadToEnd().Split(' ').Select(n => int.Parse(n)).ToArray();
                for (int i = 1; i < arrayInt.Length; i++)
                {if (arrayInt[i - 1] != arrayInt[i])
                    {count++;}
                }
            }
            catch (FormatException) { MessageBox.Show("ошибка: файл должен содержать только целые числа"); }
            streamReader.Close();
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(File.Create(@"../../" + Path.GetFileNameWithoutExtension(fileName) + ".out"));
                streamWriter.WriteLine(count.ToString());
                streamReader.Close();
                streamWriter.Close();
            }
            catch (NullReferenceException) { }
        }
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            streamReader.Close();
        }
        private void createRandomFileButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fileName = (@"../../" + rnd.Next(9999).ToString() + ".in");
            StreamWriter streamWriter = new StreamWriter(File.Create(fileName));
            {
                int numberIteration = rnd.Next(100);
                for (int i = 0; i < numberIteration; i++)
                {streamWriter.Write((rnd.Next(i % 10)).ToString());
                    if (i != numberIteration - 1)
                        streamWriter.Write(' ');}
            }
            streamWriter.Close();
            streamReader = new StreamReader(fileName);
            doCounting();
        }
    }
}
