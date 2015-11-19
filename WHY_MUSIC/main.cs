using System;
using System.Windows.Forms;

namespace WHY_MUSIC
{
    public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
            Application.Run(new headband1());
    }

    private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
    {

    }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_in_form f = new Sign_in_form();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sign_up_form f = new Sign_up_form();
            f.Show();
                }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Do you confirm your choice?", "confirm", buttons);
         
            if (result != DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            feedback f = new feedback();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            anketa a = new anketa();
            a.Show();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)                
        Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();

            WindowState = FormWindowState.Normal;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            ri s = new ri();
            s.Show();
        }
    }
}
