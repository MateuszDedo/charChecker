using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharDetector
{
    public partial class frmPlayerAnalyze : Form
    {
        public frmPlayerAnalyze()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtFullAnalyze.Text = "";
            txtUniqueCount.Text = "";
            List<string> players = new List<string>();
            StreamReader sr = new StreamReader(txtPath.Text);
            while (!sr.EndOfStream)
            {
                string l = sr.ReadLine();
                players.Add(l.Substring(0, l.IndexOf('[') - 1).Replace("Player ", ""));

            }
            sr.Close();

            int i = 0;

            List<string> suspectPlayers = new List<string>();
            progressBar1.Maximum = players.Count + 1;

            foreach (string s in players)
            {
                progressBar1.Value = i;
                Application.DoEvents();

                i++;
                if (s == txtPlayerName.Text)
                {
                    
                    int idxStart = i - Convert.ToInt32(txtDepth.Text);
                    if (idxStart < 0) idxStart = 0;
                    int idxEnd = i + Convert.ToInt32(txtDepth.Text);
                    for (int a = idxStart; a < idxEnd; a++)
                    {
                        try
                        {
                            suspectPlayers.Add(players[a]);
                            txtFullAnalyze.Text += players[a] + "\n";
                        }
                        catch (Exception)
                        { }
                    }
                }
            }

           

            var result = from id in suspectPlayers
                         group id by id into g
                         orderby g.Count() descending
                         select new { Id = g.Key, Count = g.Count() };

            foreach (var grp in result)
            {
                txtUniqueCount.Text += grp.Id + ": " + grp.Count + " \n";
            }
        }
    }
}
