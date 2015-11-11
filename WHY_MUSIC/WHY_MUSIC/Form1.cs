using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
