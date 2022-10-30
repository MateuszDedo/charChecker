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
    public partial class McDetector : Form
    {
        List<string> lastReceived = null;
        public McDetector()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HttpManager mgr = new HttpManager();
            var users = mgr.GetUsers();
            Update(users);
        }

        private void Update(List<string> users)
        {
            AddUsers(users, treeView1);
            RefreshBlackedList(txtBlackList.Text.Split(',').ToList());
        }

        private void AddUsers(List<string> users, TreeView tv)
        {
            List<string> LoggedOutUsers = new List<string>();
            List<string> LoggedInUsers = new List<string>();

            StreamWriter sw = new StreamWriter("PlayersHistory", true);
            foreach (TreeNode tvi in tv.Nodes)
            {
                if (!users.Contains(tvi.Text))
                {
                    if (tvi.ForeColor == Color.Green)
                    {
                        LoggedOutUsers.Add(tvi.Text);
                        tvi.ForeColor = Color.Red;
                    }
                }
            }

            foreach (var u in users)
            {
                TreeNode[] tnc = tv.Nodes.Find(u, false);

                if (tnc.Length == 0)
                {
                    LoggedInUsers.Add(u);
                    var t = tv.Nodes.Add(u, u);
                    t.ForeColor = Color.Green;
                }
                else if (tnc[0].ForeColor == Color.Red)
                {
                    LoggedInUsers.Add(u);
                    TreeNode tn = tnc[0];
                    tn.ForeColor = Color.Green;
                }
            }

            foreach (var s in LoggedInUsers)
            {
                sw.WriteLine("Player " + s + " [LOG IN][" + DateTime.Now.ToLongTimeString() + "]");
                TreeNode[] tnc = tv.Nodes.Find(s, false);
                if (tnc.Length == 0) continue;
                TreeNode tn = tnc[0];
                if (tn != null)
                {
                    foreach (var lout in LoggedOutUsers)
                    {
                        tn.Nodes.Add(lout, lout);
                    }
                }
            }

            foreach (var s in LoggedOutUsers)
            {
                sw.WriteLine("Player " + s + " [LOG OUT][" + DateTime.Now.ToLongTimeString() + "]");
                TreeNode[] tnc = tv.Nodes.Find(s, false);
                if (tnc.Length == 0) continue;
                TreeNode tn = tnc[0];
                if (tn != null)
                {
                    foreach (var lout in LoggedInUsers)
                    {
                        tn.Nodes.Add(lout);
                    }
                }
            }
            sw.Close();
        }

        private void RefreshBlackedList(List<string> users)
        {

            foreach (TreeNode tn in treeView1.Nodes)
            {
                if (users.Contains(tn.Text))
                {
                    var fnode = tvblackList.Nodes.Find(tn.Text, false);
                    if (fnode.Length == 0)
                    {
                        var n = tvblackList.Nodes.Add(tn.Text, tn.Text);
                        n.ForeColor = tn.ForeColor;
                        foreach (TreeNode tni in tn.Nodes)
                            n.Nodes.Add(tni.Text);
                    }
                    else
                    {
                        fnode[0].ForeColor = tn.ForeColor;
                        fnode[0].Nodes.Clear();
                        foreach (TreeNode tni in tn.Nodes)
                            fnode[0].Nodes.Add(tni.Text);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = Convert.ToInt32(txtTimeout.Text);
            timer1.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    sw.WriteLine("1" + tn.Text);
                    foreach (TreeNode tni in tn.Nodes)
                        sw.WriteLine("2" + tni.Text);
                }
                sw.WriteLine("3" + txtBlackList.Text);

                foreach (TreeNode tn in tvExpChanged.Nodes)
                {
                    sw.WriteLine("4" + tn.Text);
                    foreach (TreeNode tni in tn.Nodes)
                        sw.WriteLine("5" + tni.Text);
                }

                sw.Close();
            }
            catch(Exception)
            { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                StreamReader sr = new StreamReader(ofd.FileName);

                TreeNode tn = new TreeNode();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Substring(0, 1) == "1")
                    {
                        tn = treeView1.Nodes.Add(line.Substring(1), line.Substring(1));
                        tn.ForeColor = Color.Red;
                    }
                    else if (line.Substring(0, 1) == "2")
                    {
                        tn.Nodes.Add(line.Substring(1));
                    }
                    else if (line.Substring(0, 1) == "3")
                    {
                        txtBlackList.Text = line.Substring(1);
                    }
                }
                sr.Close();
            }
            catch (Exception)
            { }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            GetExp();
        }

        private void GetExp()
        {
            timer1.Stop();
            timer2.Stop();
            HttpManager man = new HttpManager();
            List<PlayerInfo> i = man.GetUsersExp();
            foreach (PlayerInfo player in i)
            {
                var fnode = tvExpChanged.Nodes.Find(player.player, false);
                if (fnode.Length == 0)
                {
                    var n = tvExpChanged.Nodes.Add(player.player, player.player);
                    n.Nodes.Add("[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "][lvl:" + player.level + "][exp: " + player.experience + "]");
                }
                else
                {
                    fnode[0].Nodes.Add("[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "][lvl:" + player.level + "][exp: " + player.experience + "]");
                }
            }
            timer1.Interval = Convert.ToInt32(txtTimeout.Text);
            timer1.Start();
            
            timer2.Interval = 1000 * 60 * 60 * 8;
            timer2.Start();
        }

        private void btnSaveExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            StreamWriter sw = new StreamWriter(sfd.FileName);

            foreach (TreeNode tn in tvExpChanged.Nodes)
            {
                sw.WriteLine("1" + tn.Text);
                foreach (TreeNode tni in tn.Nodes)
                    sw.WriteLine("2" + tni.Text);
            }

            sw.Close();
        }

        private void btnLoadExp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            StreamReader sr = new StreamReader(ofd.FileName);

            TreeNode tnChanged = new TreeNode();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                if (line.Substring(0, 1) == "1")
                {
                    tnChanged = tvExpChanged.Nodes.Add(line.Substring(1), line.Substring(1));
                }
                else if (line.Substring(0, 1) == "2")
                {
                    tnChanged.Nodes.Add(line.Substring(1));
                }
            }
            sr.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GetExp();
        }

        private void tvExpChanged_DoubleClick(object sender, EventArgs e)
        {
            if (tvExpChanged.SelectedNode != null)
            {
                PlayerHistory ph = new PlayerHistory();
                List<PlayerInfo> pi = new List<PlayerInfo>();
                foreach (TreeNode tn in tvExpChanged.SelectedNode.Nodes)
                {
                    pi.Add(new PlayerInfo()
                    {
                        date = tn.Text.Split(']')[0].Replace("[", ""),
                        player = tvExpChanged.SelectedNode.Text,
                        level = tn.Text.Split(']')[1].Replace("[lvl:", ""),
                        experience = tn.Text.Split(']')[2].Replace("[exp: ", "").Replace(",", "")
                    });
                }
                ph.pi = pi;
                ph.pname = tvExpChanged.SelectedNode.Text;
                TreeNode[] fnode2 = treeView1.Nodes.Find(tvExpChanged.SelectedNode.Text, false);
                if (fnode2.Length > 0)
                {
                    foreach (TreeNode s in fnode2[0].Nodes)
                    {
                        ph.other.Add(s.Text);
                    }
                }
                
                ph.Show();
            }
        }

        private void tvblackList_DoubleClick(object sender, EventArgs e)
        {
            if (tvblackList.SelectedNode != null)
            {
                TreeNode[] fnode = tvExpChanged.Nodes.Find(tvblackList.SelectedNode.Text, false);
                if (fnode.Length == 0)
                {
                    return;
                }
                
                PlayerHistory ph = new PlayerHistory();
                List<PlayerInfo> pi = new List<PlayerInfo>();
                foreach (TreeNode tn in fnode[0].Nodes)
                {
                    pi.Add(new PlayerInfo()
                    {
                        date = tn.Text.Split(']')[0].Replace("[", ""),
                        player = fnode[0].Text,
                        level = tn.Text.Split(']')[1].Replace("[lvl:", ""),
                        experience = tn.Text.Split(']')[2].Replace("[exp: ", "").Replace(",", "")
                    });
                }
                ph.pi = pi;
                ph.pname = fnode[0].Text;
                TreeNode[] fnode2 = treeView1.Nodes.Find(tvblackList.SelectedNode.Text, false);
                if (fnode2.Length > 0)
                {
                    foreach (TreeNode s in fnode2[0].Nodes)
                    {
                        ph.other.Add(s.Text);
                    }
                }
                ph.Show();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            frmPlayer p = new frmPlayer();
            p.ShowDialog();
            TreeNode[] fnode = tvExpChanged.Nodes.Find(p.player, false);
            if (fnode.Length == 0)
            {
                return;
            }

            PlayerHistory ph = new PlayerHistory();
            List<PlayerInfo> pi = new List<PlayerInfo>();
            foreach (TreeNode tn in fnode[0].Nodes)
            {
                pi.Add(new PlayerInfo()
                {
                    date = tn.Text.Split(']')[0].Replace("[", ""),
                    player = fnode[0].Text,
                    level = tn.Text.Split(']')[1].Replace("[lvl:", ""),
                    experience = tn.Text.Split(']')[2].Replace("[exp: ", "").Replace(",", "")
                });
            }
            ph.pi = pi;
            ph.pname = fnode[0].Text;
            TreeNode[] fnode2 = treeView1.Nodes.Find(p.player, false);
            if (fnode2.Length > 0)
            {
                foreach (TreeNode s in fnode2[0].Nodes)
                {
                    ph.other.Add(s.Text);
                }
            }
            ph.Show();
        }

        private void btnRemoveBlack_Click(object sender, EventArgs e)
        {
            if (tvblackList.SelectedNode != null)
            {
                tvblackList.SelectedNode.Remove();
            }
        }

        private void btnRemoveChar_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                TreeNode[] fnode = tvExpChanged.Nodes.Find(treeView1.SelectedNode.Text, false);
                if (fnode.Length == 0)
                {
                    return;
                }

                PlayerHistory ph = new PlayerHistory();
                List<PlayerInfo> pi = new List<PlayerInfo>();
                foreach (TreeNode tn in fnode[0].Nodes)
                {
                    pi.Add(new PlayerInfo()
                    {
                        date = tn.Text.Split(']')[0].Replace("[", ""),
                        player = fnode[0].Text,
                        level = tn.Text.Split(']')[1].Replace("[lvl:", ""),
                        experience = tn.Text.Split(']')[2].Replace("[exp: ", "").Replace(",", "")
                    });
                }
                ph.pi = pi;
                ph.pname = fnode[0].Text;
                TreeNode[] fnode2 = treeView1.Nodes.Find(treeView1.SelectedNode.Text, false);
                if (fnode2.Length > 0)
                {
                    foreach (TreeNode s in fnode2[0].Nodes)
                    {
                        ph.other.Add(s.Text);
                    }
                }
                ph.Show();
            }
        }

        private void btnPlayerAnalyze_Click(object sender, EventArgs e)
        {
            frmPlayerAnalyze f = new frmPlayerAnalyze();
            f.Show();
        }
    }
}
