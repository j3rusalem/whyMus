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
    public partial class Sign_up_form : Form
    {
        public Sign_up_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Do you confirm your choice?", "confirm", buttons);
             
             if ( result == DialogResult.Yes)
            {
                this.Close();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            
            DialogResult result = MessageBox.Show("Are you shore that you want try again?", "confirm", buttons);

            if ( result == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
    }
}
