using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LB4Extract;

namespace PM2ExtractGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            bool b = false;
            if(!File.Exists(lb4FilePath.Text))
            {
                b = false;
            }
            else if(!Directory.Exists(extractPath.Text))
            {
                b = false;
            }
            else
            {
                b = true;
            }
            Extract.Enabled = b;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            lb4File.ShowDialog();
        }

        private void lb4File_FileOk(object sender, CancelEventArgs e)
        {
            lb4FilePath.Text = lb4File.FileName;
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = extractFolder.ShowDialog();
            if(result == DialogResult.OK)
            {
                extractPath.Text = PM2Util.MakeDirStr(extractFolder.SelectedPath);
            }
        }

        private void Extract_Click(object sender, EventArgs e)
        {
            LB4Extractor extractor = new LB4Extractor(lb4FilePath.Text);
            LB4ArchiveInfo archiveInfo = extractor.getArchiveInfo();
            foreach(LB4Entry entry in archiveInfo.Entries)
            {
                File.WriteAllBytes(extractPath.Text + entry.Name, entry.Buffer);
            }
            MessageBox.Show(string.Format("Extraction has done! File count:{0}", archiveInfo.Count));
        }
    }
    class PM2Util
    {
        public static string MakeDirStr(string path)
        {
            return path.EndsWith(@"\") ? path : path + "\\";
        }
    }
}
