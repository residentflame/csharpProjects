
namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void generateTable_Click(object sender, EventArgs e)
        {
            string text = multiplicationNum.Text;
            if (Int32.TryParse(text, out int num))
            {
                ThePrinter printer = new ThePrinter();
                string result = printer.print(num);

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void multiplicationNum_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
