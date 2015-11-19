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
    public partial class ri : Form
    {
        public ri()
        {
            InitializeComponent();
        }

        private void sostoyanie_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sostoyanie_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sostoyanie_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Console.NumberLock)
            {
                label2.Text = "Num lock is active";

            }
            else
            {
                label2.Text = "Num lock isn't active ";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Console.CapsLock)
            {
                label3.Text = "Caps is active";
            }
            else
            {
                label3.Text = "Caps isn't active";
            }
        }
    }
}
