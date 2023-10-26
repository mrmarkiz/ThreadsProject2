namespace Task7Form
{
    public partial class Form1 : Form
    {
        private string _vowels = "aeiouy";
        private string _consonants = "bcdfghjklmnpqrstvwxz";
        public Form1()
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