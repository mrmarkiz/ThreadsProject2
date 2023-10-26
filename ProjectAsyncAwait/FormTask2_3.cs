using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsyncAwait
{
    public partial class FormTask2_3 : Form
    {
        public FormTask2_3()
        {
            InitializeComponent();
        }

        private void buttonFrom_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSource = new OpenFileDialog();
            if (openSource.ShowDialog() == DialogResult.OK)
            {
                labelFrom.Text = openSource.FileName;
            }
        }

        private void buttonTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDest = new SaveFileDialog();
            if (saveDest.ShowDialog() == DialogResult.OK)
            {
                labelTo.Text = saveDest.FileName;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelFrom.Text) || string.IsNullOrEmpty(labelTo.Text))
            {
                MessageBox.Show("Set to and from pathes");
                return;
            }
            _copy(labelFrom.Text, labelTo.Text);
        }

        private async Task _copy(string source, string dest)
        {
            File.Copy(source, dest, true);
        }
    }
}
