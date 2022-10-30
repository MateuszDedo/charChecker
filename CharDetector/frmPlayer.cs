using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharDetector
{
    public partial class frmPlayer : Form
    {
        public string player;
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player = textBox1.Text;
            this.Close();
        }
    }
}
