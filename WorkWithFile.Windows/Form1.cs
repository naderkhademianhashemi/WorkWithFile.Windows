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

namespace WorkWithFile.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSlctFLDR_Click(object sender, EventArgs e)
        {
            var fldrBrwsrDlg = new FolderBrowserDialog();
            if (fldrBrwsrDlg.ShowDialog() == DialogResult.OK)
                textBox1.Text = fldrBrwsrDlg.SelectedPath;
        }

        private void btnLstFLDR_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBox1.Text))
            {
                MessageBox.Show("Dir !Exist"); return;
            }
            var path = Path.GetFullPath(textBox1.Text);
            var files = Directory.GetDirectories(path);
            var svFlDlg = new SaveFileDialog();

            if (svFlDlg.ShowDialog() == DialogResult.OK)
                File.WriteAllLines(svFlDlg.FileName, files, Encoding.UTF8);

            MessageBox.Show("file saved");

        }

        private void btnMergeFileFldr_Click(object sender, EventArgs e)
        {
            var path = Path.GetFullPath(textBox1.Text);
            var files = Directory.GetFiles(path);
            Encoding encoding = Encoding.UTF8;

            var filename = path + $"\\merge-{DateTime.Now:MM-dd-HH-mm}.txt";
            File.WriteAllText(filename, "", encoding);
            foreach (var file in files)
                File.AppendAllLines(filename, File.ReadAllLines(file, Encoding.Default));

            MessageBox.Show("merge file content of fldr saved!");
        }
    }
}
