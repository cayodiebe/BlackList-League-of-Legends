using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackList
{
    public partial class Main : Form
    {
        private List<string> blacklist;
        private string filePath = Path.Combine(Environment.CurrentDirectory, "blacklist.txt");
        private string lobbyText = " entrou no lobby";

        public Main()
        {
            InitializeComponent();
            openFile();
            fsw.Path = Environment.CurrentDirectory;
        }

        private void openFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    UpdateFileView();
                    UpdateFileViewList();
                    blacklist = File.ReadAllLines(filePath).OfType<string>().ToList();
                    Console.WriteLine("Carregando arquivo...");
                }
                else
                {
                    File.Create(filePath).Close();
                    blacklist = new List<string>();
                    Console.WriteLine("Arquivo não encontrado, criando novo..");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OpenFile: " + ex.Message);
            }
        }

        private bool writeLine(string str)
        {
            try
            {
                fsw.EnableRaisingEvents = false;
                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, str + Environment.NewLine);
                    UpdateFileView();
                    UpdateFileViewList();
                    Console.WriteLine("Successfully wrote: " + str + " to file");
                    fsw.EnableRaisingEvents = true;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("WriteLine: " + ex.Message);
            }
            return false;
        }

        private void searchMulti(string[] str)
        {
            rtbOutput.Text = "";
            str = removeLobbyText(str);

            foreach (string s in str)
            {
                if (blacklist.Count >= 0 && blacklist.Contains(s))
                {
                    rtbOutput.Text += s + " já está inserido\n";
                }
                else
                {
                    if (writeLine(s))
                    {
                        rtbOutput.Text += s + " adicionado na blacklist\n";
                        blacklist.Add(s);
                    }
                }
            }
        }

        private string[] checkMulti(string[] str)
        {
            rtbOutput.Text = "";
            str = removeLobbyText(str);
            List<string> output = new List<string>();

            foreach (string s in str)
            {
                if (blacklist.Count >= 0 && blacklist.Contains(s))
                {
                    rtbOutput.Text += s + " já está inserido na blacklist\n";
                }
                else
                {
                    output.Add(s);
                }
            }
            return output.ToArray();
        }

        private string[] removeLobbyText(string[] str)
        {
            return str.Select(s => s.Replace(lobbyText, "")).ToArray();
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            if (rtbInput.Text != null && !rtbInput.Text.Equals(""))
            {
                foreach(var retrover in rtbInput.Lines)
                {
                    string[] stringArray = new string[] { retrover.ToString() };
                    searchMulti(stringArray);
                }
            }
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filePath);
        }

        private void rtbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && rtbInput.Text != null && !rtbInput.Text.Equals(""))
            {
                e.SuppressKeyPress = true;
                Console.WriteLine("Procurando...");
                //searchMulti(rtbInput.Lines);
                rtbInput.Lines = checkMulti(rtbInput.Lines);
            }
        }

        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                blacklist = File.ReadAllLines(filePath).OfType<string>().ToList();
                UpdateFileView();
            }
            catch
            {
                Thread.Sleep(TimeSpan.FromSeconds(50));
            }
        }

        private string outputBlacklist()
        {
            string output = "";
            foreach (string s in blacklist)
            {
                output += s + "\n";
            }
            return output;
        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {
            CheckKeyword("already", Color.Red);
            CheckKeyword("added", Color.Green);
        }

        private void CheckKeyword(string word, Color color)
        {
            foreach (string s in rtbOutput.Lines)
            {
                if (s.Contains(word))
                {
                    rtbOutput.Find(s);
                    rtbOutput.SelectionColor = color;
                }
            }
        }

        private void UpdateFileView()
        {
            lvFileText.Items.Clear();
            string[] temp = File.ReadAllLines(filePath);
            Console.WriteLine("Temp length: " + temp.Length);
            temp = temp.Reverse().ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                lvFileText.Items.Add(temp[i]);
            }
        }

        private void UpdateFileViewList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nome");
            dt.Columns.Add("Motivo");
            string[] temp = File.ReadAllLines(filePath);
            temp = temp.Reverse().ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                var rows = temp[i].Split(',');
                dt.Rows.Add(rows[0].ToString(), rows[1].ToString());
            }
            dtGridList.DataSource = dt;
        }

        private void lvFileText_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvFileText.SelectedItems.Count > 0)
            //{
            //    visitSite(lvFileText.SelectedItems[0].Text);
            //    lvFileText.SelectedItems.Clear();
            //}
        }

        private void visitSite(string user)
        {
            System.Diagnostics.Process.Start("https://br.op.gg/summoner/userName={{replacethis}}".Replace("{{replacethis}}", user));
        }

        private void lvFileText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvFileText.SelectedItems.Count > 0)
            {
                visitSite(lvFileText.SelectedItems[0].Text);
            }
        }      
    }
}