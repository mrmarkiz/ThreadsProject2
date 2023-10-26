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
    public partial class FormTask1 : Form
    {
        public FormTask1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                return;
            }
            Button clicked = (Button)sender;
            switch (clicked.Tag)
            {
                case "n":
                    GenerateNums(listBoxNums, (int)numericUpDown1.Value);
                    break;
                case "l":
                    GenerateLetters(listBoxLett, (int)numericUpDown1.Value);
                    break;
                case "s":
                    GenerateSymbols(listBoxSymb, (int)numericUpDown1.Value);
                    break;
            }
        }

        private async Task GenerateNums(ListBox listBox, int count)
        {
            listBox.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add(rnd.Next(-100, 101));
                await Task.Delay(100);
            }
        }

        private async Task GenerateLetters(ListBox listBox, int count)
        {
            listBox.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add((char)rnd.Next(65, 91));
                await Task.Delay(100);
            }
        }
        private async Task GenerateSymbols(ListBox listBox, int count)
        {
            listBox.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                char symbol;
                do
                {
                    symbol = (char)rnd.Next(1, 129);
                } while (char.IsLetterOrDigit(symbol));
                listBox.Items.Add(symbol);
                await Task.Delay(100);
            }
        }
    }
}
