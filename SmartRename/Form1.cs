using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartRename
{
    public partial class Form1 : Form
    {
        object[] row;
        List<string> fileNames;

        public Form1()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = folderBrowserDiag.ShowDialog();

            if (diagResult == DialogResult.OK)
            {
                txtbx_folder.Text = folderBrowserDiag.SelectedPath;
                EnumerateFiles();
                evalReg();
            }
        }

        private void EnumerateFiles()
        {
            var files = Directory.EnumerateFiles(txtbx_folder.Text);

            fileNames = new List<string>();

            foreach (var f in files)
            {
                fileNames.Add(Path.GetFileName(f));
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dtGrdRw in dtGrd_convert.Rows)
            {
                if ((bool)dtGrdRw.Cells[0].Value)
                {
                    var oldPath = Path.Combine(txtbx_folder.Text, (string)dtGrdRw.Cells[1].Value);
                    var newPath = Path.Combine(txtbx_folder.Text, (string)dtGrdRw.Cells[2].Value);

                    File.Move(oldPath, newPath);
                }
            }
            EnumerateFiles();
            evalReg();
        }

        private void txtbx_regin_TextChanged(object sender, EventArgs e)
        {
            evalReg();
        }

        private void txtbx_regout_TextChanged(object sender, EventArgs e)
        {
            evalReg();
        }

        private void evalReg()
        {
            dtGrd_convert.Rows.Clear();
            dtGrd_convert.Refresh();

            var pattern = txtbx_regin.Text;
            foreach (var input in fileNames)
            {
                try
                {
                MatchCollection matches = Regex.Matches(input, pattern);

                List<string> values = new List<string>();

                foreach (Group group in matches[0].Groups)
                {
                    values.Add(group.Value);
                }
                row = new object[] { true, input, string.Format(txtbx_regout.Text, values.ToArray()) };
                dtGrd_convert.Rows.Add(row);
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtbx_folder_Leave(object sender, EventArgs e)
        {
            if (Directory.Exists(txtbx_folder.Text))
            {
                EnumerateFiles();
                evalReg();
            }
        }
    }
}