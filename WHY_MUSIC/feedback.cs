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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contacts c = new contacts();
            c.Show();

        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
