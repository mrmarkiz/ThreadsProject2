namespace ProjectAsyncAwait
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            Form formTask = new Form();
            switch (clicked.Tag)
            {
                case "1":
                    formTask = new FormTask1();
                    break;
                case "2":
                case "3":
                    formTask = new FormTask2_3();
                    break;
                case "4":
                case "5":
                    formTask = new FormTask4_5();
                    break;
                case "6":
                    formTask = new FormTask6();
                    break;
                case "7":
                    formTask = new FormTask7();
                    break;
                case "8":
                    formTask = new FormTask8();
                    break;
            }
            formTask.Show();
        }
    }
}