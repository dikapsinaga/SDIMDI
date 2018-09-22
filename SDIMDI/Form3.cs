using System;
using System.Windows.Forms;

namespace SDIMDI
{
    public partial class Form3 : Form
    {
        private static FormSDIMDI frm1 = new FormSDIMDI();

        public Form3()
        {
            InitializeComponent();
        }
    

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void sendToParent_Click(object sender, EventArgs e)
        {
            String message = frm1.getMessage() + "Tiga :" + textBox.Text + "\n";
            frm1.setMessage(message);
        }

        private void getFromParent_Click(object sender, EventArgs e)
        {
            richTextBox.Text = frm1.getMessage();
        }
    }
}
