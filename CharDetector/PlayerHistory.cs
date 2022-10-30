using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class PlayerHistory : Form
    {
        public List<PlayerInfo> pi = new List<PlayerInfo>();
        public string pname;
        public List<string> other = new List<string>();
        public PlayerHistory()
        {
            InitializeComponent();
        }

        private void PlayerHistory_Load(object sender, EventArgs e)
        {
            lsExp.Columns.Add("DATE", 200);
            lsExp.Columns.Add("EXP", 200);
            lsExp.Columns.Add("DIFF", 200);

            lsSuspect.Columns.Add("NAME");

            foreach(string s in other)
            {
                lsSuspect.Items.Add(s);
            }

            ChartValues<int> experience = new ChartValues<int>();
            label1.Text = pname;
            int prev = 0;
            foreach (PlayerInfo p in pi)
            {
                if (prev == 0)
                {
                    prev = Convert.ToInt32(p.experience);
                }
                experience.Add(Convert.ToInt32(p.experience));
                lsExp.Items.Add(new ListViewItem(new string[] { p.date, p.experience, (Convert.ToInt32(p.experience) - prev).ToString() }));
                prev = Convert.ToInt32(p.experience);
            }
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Experience",
                    Values = experience
                }
            };

        }
    }
}
