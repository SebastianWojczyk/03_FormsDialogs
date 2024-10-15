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
    public partial class FormExampleDialog : Form
    {
        public string FirstName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public FormExampleDialog()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 3)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
