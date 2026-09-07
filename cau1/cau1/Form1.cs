namespace cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtPassWord.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            txtPassWord.Clear();
            txtPassWord.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
