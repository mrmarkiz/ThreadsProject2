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
    public partial class FormTask8 : Form
    {
        private string _vowels = "aeiouy";
        private string _consonants = "bcdfghjklmnpqrstvwxz";
        public FormTask8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateVowels(textBox1.Text, labelVowels);
            calculateConsonants(textBox1.Text, labelConsonants);
            calculateOthers(textBox1.Text, labelSymbols);
        }

        private async Task calculateVowels(string text, Label label)
        {
            List<char> input = text.ToList();
            int count = input.Count(sym => _vowels.Contains(sym));
            label.Text = $"Vowels: {count}";
        }

        private async Task calculateConsonants(string text, Label label)
        {
            List<char> input = text.ToList();
            int count = input.Count(sym => _consonants.Contains(sym));
            label.Text = $"Consonants: {count}";
        }

        private async Task calculateOthers(string text, Label label)
        {
            List<char> input = text.ToList();
            int count = input.Count(sym => !_vowels.Contains(sym) && !_consonants.Contains(sym));
            label.Text = $"Others: {count}";
        }
    }
}
