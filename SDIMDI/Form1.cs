using System;
using System.Windows.Forms;

namespace SDIMDI
{
    public partial class FormSDIMDI : Form
    {
        private Form2 frm2;
        private Form3 frm3;
        private Form4 frm4;
        private static String sharedMessage = "";

        public FormSDIMDI()
        {
            InitializeComponent();
        }

        public void setMessage(string message)
        {
            sharedMessage = message;
        }

        public String getMessage()
        {
            return sharedMessage;
        }

        public string str
        {
            set
            {
                str = value;
            }
            get
            {
                return str;
            }
        }
        

        private void showSDI_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
        }

        private void hideSDI_Click(object sender, EventArgs e)
        {
            if(frm2 != null)
            {
                frm2.Hide();
            }
        }

        private void maxSDI_Click(object sender, EventArgs e)
        {
            if(frm2 != null)
            {
                frm2.WindowState = FormWindowState.Maximized;
            }
        }

        private void minSDI_Click(object sender, EventArgs e)
        {
            if (frm2 != null)
            {
                frm2.WindowState = FormWindowState.Minimized;
            }
        }

        private void showMDI_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void hideMDI_Click(object sender, EventArgs e)
        {
            if (frm3 != null)
            {
                frm3.Hide();
            }
        }

        private void maxMDI_Click(object sender, EventArgs e)
        {
            if (frm3 != null)
            {
                frm3.WindowState = FormWindowState.Maximized;
            }
        }

        private void minMDI_Click(object sender, EventArgs e)
        {
            if (frm3 != null)
            {
                frm3.WindowState = FormWindowState.Minimized;
            }
        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm4 = new Form4();
            frm4.Show();
        }
    }
}