namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gray;
            lbl_Name.ForeColor = Color.Red;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Gray;
            lbl_LastName.ForeColor = Color.Red;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Gray;
            lbl_FatherName.ForeColor = Color.Red;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Gray;
            Lbl_Code.ForeColor = Color.Red;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            lbl_Name.ForeColor = Color.Black;

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            lbl_LastName.ForeColor = Color.Black;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
            lbl_FatherName.ForeColor = Color.Black;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
            Lbl_Code.ForeColor = Color.Black;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0) 
            {
                MessageBox.Show("Please Fill up the texts"); 
            }
            else
            {
                MessageBox.Show("Welcome"); 
            }
            
        }
    }
}
