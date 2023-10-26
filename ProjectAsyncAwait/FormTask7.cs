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
    public partial class FormTask7 : Form
    {
        public FormTask7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(listBox1, (int)numericUpDownNumber.Value, (int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
        }

        private async Task Calculate(ListBox listBox, int number, int start, int end)
        {
            listBox.Items.Clear();
            for (int i = start; i <= end; i++)
            {
                listBox.Items.Add($"{number}^{i} = {Math.Pow(number, i)}");
            }
        }
    }
}
