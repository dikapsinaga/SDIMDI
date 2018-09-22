using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDIMDI
{
    public partial class Form2 : Form
    {
        private static FormSDIMDI frm1 = new FormSDIMDI();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sendToParent_Click(object sender, EventArgs e)
        {
            String message = frm1.getMessage() + "Dua :" + textBox.Text + "\n";
            frm1.setMessage(message);
        }

        private void getFromParent_Click(object sender, EventArgs e)
        {
            richTextBox.Text = frm1.getMessage();
        }
    }
}
