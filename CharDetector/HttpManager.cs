using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CharDetector
{
    public struct PlayerInfo
    {
        public string player;
        public string level;
        public string experience;
        public string date;
    }
    public class HttpManager
    {
        public List<string> GetUsers()
        {
            try
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString("https://vlt.nostalther.com/onlinelist.php");
                List<string> r = new List<string>();
                string[] lines = downloadString.Split('\n');
                foreach (var line in lines)
                {
                    if (line.Contains("<td><a href=\"characterprofile.php?name="))
                    {
                        string s = line.Replace("<td><a href=\"characterprofile.php?name=", "").Trim();
                        int idx = s.LastIndexOf("\">") + 1;
                        s = s.Substring(idx + 1).Replace("</a></td>", "");
                        r.Add(s);
                    }
                }
                return r;
            }
            catch (Exception) { return new List<string>(); }
        }

        
        public List<PlayerInfo> GetUsersExp()
        {
            try
            {
                List<PlayerInfo> r = new List<PlayerInfo>();
                for (int i = 1; i <= 20; i++)
                {
                    WebClient client = new WebClient();
                    string downloadString = client.DownloadString("https://vlt.nostalther.com/highscores.php?type=7&vocation=all&page=" + i);

                    string[] lines = downloadString.Split('\n');
                    int a = 0;

                    foreach (var line in lines)
                    {

                        if (line.Contains("<td><a href=\"characterprofile.php?name="))
                        {
                            string s = line.Replace("<td><a href=\"characterprofile.php?name=", "").Trim();
                            int idx = s.LastIndexOf("\">") + 1;
                            string player = s.Substring(idx + 1).Replace("</a></td>", "");

                            s = lines[a + 2].Replace("<td>", "");
                            idx = s.LastIndexOf("</td>");
                            string level = s.Substring(0, idx).Replace("</td>", "").Trim();

                            s = lines[a + 3].Replace("<td>", "");
                            idx = s.LastIndexOf("</td>");
                            string exp = s.Substring(0, idx).Replace("</td>", "").Trim();
                            PlayerInfo pi = new PlayerInfo() { player = player, level = level, experience = exp };
                            r.Add(pi);
                        }

                        a++;
                    }
                }
                return r;
            }
            catch (Exception)
            {
                return new List<PlayerInfo>();
            }
        }
    }
}
