namespace AplicatieChestionareAuto
{
    public partial class MainForm : Form
    {
        private string nextPage;

        public MainForm()
        {
            InitializeComponent();
        }

        public string GetNextPage()
        {
            return this.nextPage;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "TipuriChestionareForm";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}