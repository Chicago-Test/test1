using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CodeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = Path.GetDirectoryName(folderBrowser.FileName);
            }
        }

        private void cmdEnumTest1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            DateTime lastWriteTime = GetLastFileModifiedSlow(txtDirectory.Text, txtFilter.Text, this.SearchOption);

            watch.Stop();

            MessageBox.Show(this, "Total time to enumerate=" + watch.ElapsedMilliseconds +
                "ms; Last write time=" + lastWriteTime,
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DateTime GetLastFileModifiedSlow(string dir, string searchPattern, SearchOption searchOption)
        {
            DateTime retval = DateTime.MinValue;

            string[] files = Directory.GetFiles(dir, searchPattern, searchOption);
            for (int i = 0; i < files.Length; i++)
            {
                DateTime lastWriteTime = File.GetLastWriteTime(files[i]);
                if (lastWriteTime > retval)
                {
                    retval = lastWriteTime;
                }
            }

            return retval;
        }

        private void cmdEnumTest2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            FastDirectoryEnumerator.MAX_DEPTH = (long)NumUpDownMaxDepth.Value;

            Stopwatch watch = new Stopwatch();
            watch.Start();

            long[] ret = GetLastFileModifiedFast(txtDirectory.Text, txtFilter.Text, this.SearchOption);

            watch.Stop();

            MessageBox.Show(this, "Total time to enumerate=" + watch.ElapsedMilliseconds / 1000 +
                "sec" + "\n" + "Number of directory=" + ret[0] + "\n" + "Number of files=" + ret[1],
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        long[] GetLastFileModifiedFast(string dir, string searchPattern, SearchOption searchOption)
        {
            //DateTime retval = DateTime.MinValue;
            //List<string> results = new List<string>();
            long[] ret = new long[2];
            System.Collections.Generic.IEnumerable<FileData> xxx = FastDirectoryEnumerator.EnumerateFiles(dir, searchPattern, searchOption).ToList(); // yoji. Need "using System.Linq"

            long numberOfDirectory = 0;
            long numberOfFiles = 0;
            foreach (FileData f in xxx)
            {
                //if (f.LastWriteTimeUtc > retval)
                //{
                //    retval = f.LastWriteTimeUtc;
                //}
                /* yoji */
                //results.Add(f.depth + ":" + f.Path);

                string parentFolderAndSubFolder = "";
                string strAttributes = ""; //f.Attributes.ToString();

                if (((FileAttributes)f.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    strAttributes = "Directory";// Attribute can be "Hidden | Directory"
                    numberOfDirectory++;
                    string[] str = (f.Path).Split(Path.DirectorySeparatorChar);
                    parentFolderAndSubFolder = str[str.Length - 2] + "\\" + f.Name;

                }
                else { strAttributes = "File"; numberOfFiles++; }

                long lenFullPath = f.Path.Length;
                long lenName = f.Name.Length;

                ListViewItem lvi;
                lvi = listView1.Items.Add(f.Path); // full path
                lvi.SubItems.Add((f.Size).ToString());
                lvi.SubItems.Add(strAttributes);
                lvi.SubItems.Add((f.Path.Length).ToString());
                lvi.SubItems.Add(f.Path.Substring(0, (int)(lenFullPath - lenName)));
                lvi.SubItems.Add(f.Name);
                lvi.SubItems.Add(f.LastWriteTimeUtc.ToString());
                lvi.SubItems.Add(f.CreationTimeUtc.ToString());
                lvi.SubItems.Add(f.LastAccessTimeUtc.ToString());
                lvi.SubItems.Add(f.depth.ToString());
                lvi.SubItems.Add(parentFolderAndSubFolder);

                //listView1.SelectedItems[0].SubItems[0].Text;
            }
            ret[0] = numberOfDirectory;
            ret[1] = numberOfFiles;

            return ret;
        }

        private void cmdEnumTest3_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            DateTime lastWriteTime = GetLastFileModifiedSlow2(txtDirectory.Text, txtFilter.Text, this.SearchOption);

            watch.Stop();

            MessageBox.Show(this, "Total time to enumerate=" + watch.ElapsedMilliseconds +
                "ms; Last write time=" + lastWriteTime,
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        DateTime GetLastFileModifiedSlow2(string dir, string searchPattern, SearchOption searchOption)
        {
            DateTime retval = DateTime.MinValue;

            DirectoryInfo dirInfo = new DirectoryInfo(dir);

            FileInfo[] files = dirInfo.GetFiles(searchPattern, searchOption);
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].LastWriteTime > retval)
                {
                    retval = files[i].LastWriteTime;
                }
            }

            return retval;
        }

        private void cmdEnumTest4_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            DateTime lastWriteTime = GetLastFileModifiedFast2(txtDirectory.Text, txtFilter.Text, this.SearchOption);

            watch.Stop();

            MessageBox.Show(this, "Total time to enumerate=" + watch.ElapsedMilliseconds +
                "ms; Last write time=" + lastWriteTime,
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DateTime GetLastFileModifiedFast2(string dir, string searchPattern, SearchOption searchOption)
        {
            DateTime retval = DateTime.MinValue;

            FileData[] files = FastDirectoryEnumerator.GetFiles(dir, searchPattern, searchOption);
            for (int i = 0; i < files.Length; i++)
            {
                if ((files[i].Attributes & FileAttributes.Directory) == 0)
                {
                    if (files[i].LastWriteTime > retval)
                    {
                        retval = files[i].LastWriteTime;
                    }
                }
            }

            return retval;
        }

        private SearchOption SearchOption
        {
            get
            {
                return chkSearchSubdirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = true;
            //listView1.HideSelection = false;


            //listView1.Columns[0].Width = 10;
            //Add column header
            listView1.Columns.Add("Full Path", 150);
            listView1.Columns.Add("Size", 50, HorizontalAlignment.Right);
            listView1.Columns.Add("Type", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Length", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Path", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("file/folder name", 250, HorizontalAlignment.Left);
            listView1.Columns.Add("DateLastModified", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("DateCreated", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("DateLastAccessed", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Depth", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Parentfolder&Subfolder", 250, HorizontalAlignment.Left);

            //////////////////////////////////////////////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            //header
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                sb.Append(listView1.Columns[i].Text + "\t");
            }
            sb.AppendLine();

            try
            {
                //foreach (var item in listView1.SelectedItems)
                foreach (var item in listView1.Items)
                {
                    ListViewItem l = item as ListViewItem;
                    if (l != null)
                        foreach (ListViewItem.ListViewSubItem sub in l.SubItems)
                            sb.Append(sub.Text + "\t");
                    sb.AppendLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\n" + "Error. Data too large. Consider exporting to a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Clipboard.SetDataObject(sb.ToString());
            MessageBox.Show("Copy to clipboard completed.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.Title = "Save an CSV File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Full Path" + "\t" + "Size" + "\t" + "Type" + "\t" + "Length" + "\t" + "Path" + "\t" + "file/folder name" + "\t" + "DateLastModified" + "\t" + "DateCreated" + "\t" + "DateLastAccessed" + "\t" + "Depth" + "\t" + "Parentfolder & Subfolder");

                    foreach (var item in listView1.Items)
                    {
                        sb.Length = 0;
                        ListViewItem lvi = item as ListViewItem;
                        if (lvi != null)
                            foreach (ListViewItem.ListViewSubItem sub in lvi.SubItems)
                                sb.Append(sub.Text + "\t");
                        sw.WriteLine(sb.ToString());
                    }
                }

                fs.Close();
            }
            MessageBox.Show("Save to file completed.");

        }

        private void NumUpDownMaxDepth_ValueChanged(object sender, EventArgs e)
        {
            //FastDirectoryEnumerator.
            FastDirectoryEnumerator.MAX_DEPTH = (long)NumUpDownMaxDepth.Value;
        }
    }
}
