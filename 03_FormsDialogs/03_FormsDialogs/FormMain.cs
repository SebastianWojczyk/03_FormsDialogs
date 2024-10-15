using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_FormsDialogs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonMessageBoxSimple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple");
        }

        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Info text",
                            "Caption",
                            MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                buttonMessageBox.Text = "YES";
            }
            else if (result == DialogResult.No)
            {
                buttonMessageBox.Text = "NO";
            }
            else if (result == DialogResult.Cancel)
            {
                buttonMessageBox.Text = "CANCEL";
            }
            else
            {
                buttonMessageBox.Text = "???";
            }
        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = buttonColorDialog.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColorDialog.BackColor = cd.Color;
            }
        }

        private void buttonFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = buttonFontDialog.Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                buttonFontDialog.Font= fd.Font;
            }
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files|*.txt|JPG|*.jpg|BMP|*.bmp";
            ofd.InitialDirectory = "Z:\\";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                buttonOpenFileDialog.AutoSize = true;
                buttonOpenFileDialog.Text = ofd.FileName;
            }
        }

        private void buttonSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text files|*.txt|JPG|*.jpg|BMP|*.bmp";
            sfd.InitialDirectory = "Z:\\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                buttonSaveFileDialog.AutoSize = true;
                buttonSaveFileDialog.Text = sfd.FileName;
            }
        }

        private void buttonFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                buttonFolderBrowserDialog.AutoSize = true;
                buttonFolderBrowserDialog.Text = fbd.SelectedPath;
            }
        }

        private void buttonFormExample_Click(object sender, EventArgs e)
        {
            FormExample fe = new FormExample();
            fe.Show();
        }

        private void buttonFormExampleDialog_Click(object sender, EventArgs e)
        {
            FormExampleDialog fed = new FormExampleDialog();

            fed.FirstName = "Example name";
            DialogResult result = fed.ShowDialog();
            if (result == DialogResult.OK)
            {
                buttonFormExampleDialog.Text = "OK! Cześć " + fed.FirstName;
                
            }
            else if (result == DialogResult.Yes)
            {
                buttonFormExampleDialog.Text = "YES";
            }
            else if (result == DialogResult.No)
            {
                buttonFormExampleDialog.Text = "NO";
            }
            else
            {
                buttonFormExampleDialog.Text = result.ToString();
            }
        }
    }
}
