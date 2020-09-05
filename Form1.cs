using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MTU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string idx = System.IO.File.ReadAllText(Application.StartupPath + "\\Idx.txt");
                if (System.Text.RegularExpressions.Regex.IsMatch(idx, "^[0-9]"))
                {
                    idxTb.Text = idx.ToString();
                    this.Height = 115;
                }
            }
            catch (System.IO.FileNotFoundException e)
            {

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            displayTb.Text = "";
            CMD("netsh interface ipv4 show interfaces");
        }

        private bool CMD(string command, bool check = false)
        {
            const int ERROR_FILE_NOT_FOUND = 2;
            const int ERROR_ACCESS_DENIED = 5;
            bool isFind = false;
            Process process = new Process();
            try
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.FileName = "cmd.exe";
                process.Start();
                process.StandardInput.WriteLine(command);
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine("exit");

                StreamReader reader = process.StandardOutput;
                string curLine = reader.ReadLine();
                int countLine = 0;
                while (!reader.EndOfStream)
                {
                    if (countLine < 4)
                    {
                        countLine++;
                        curLine = reader.ReadLine();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(curLine))
                        {
                            if (check)
                            {
                                Console.WriteLine(curLine);
                                if (curLine == "確定。" || curLine == "Ok.")
                                {
                                    return true;
                                }
                                else
                                    reader.Close();
                                process.WaitForExit();
                                process.Close();
                                return false;
                            }
                            else
                            {
                                Console.WriteLine(curLine);
                                displayTb.Text += curLine + "\r\n";
                                isFind = true;
                            }
                        }
                        else
                        {
                            try
                            {
                                displayTb.Text = displayTb.Text.Remove(displayTb.Text.LastIndexOf("\r\n"));
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e);
                            }
                        }
                        curLine = reader.ReadLine();
                    }
                }
                reader.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (Win32Exception e)
            {
                if (e.NativeErrorCode == ERROR_FILE_NOT_FOUND)
                {
                    Console.WriteLine(e.Message + ". Check file path.");
                }
                else if (e.NativeErrorCode == ERROR_ACCESS_DENIED)
                {
                    Console.WriteLine(e.Message + ". Permision is not enough.");
                }
                isFind = false;
            }
            if (isFind)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idxTb.Text, "^[0-9]"))
            {
                Console.WriteLine("netsh interface ipv4 set subinterface \"" + idxTb.Text + "\" mtu=" + mtuOnTb.Text + " store=persistent");
                if (CMD("netsh interface ipv4 set subinterface \"" + idxTb.Text + "\" mtu=" + mtuOnTb.Text + " store=persistent", true))
                {
                    MessageBox.Show("設定完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Idx錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Height = 320;
                }
            }
            else
            {
                MessageBox.Show("請先設定Idx", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayTb.Text = "";
            CMD("netsh interface ipv4 show interfaces");
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idxTb.Text, "^[0-9]"))
            {
                Console.WriteLine("netsh interface ipv4 set subinterface \"" + idxTb.Text + "\" mtu=" + mtuOffTb.Text + " store=persistent");
                if (CMD("netsh interface ipv4 set subinterface \"" + idxTb.Text + "\" mtu=" + mtuOffTb.Text + " store=persistent", true))
                {
                    MessageBox.Show("設定完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Idx錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Height = 320;
                }
            }
            else
            {
                MessageBox.Show("請先設定Idx", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayTb.Text = "";
            CMD("netsh interface ipv4 show interfaces");
        }

        private void setNetNameBtn_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idxTb.Text, "^[0-9]"))
            {
                System.IO.File.WriteAllText(Application.StartupPath + "\\Idx.txt", idxTb.Text);
                MessageBox.Show("設定完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Idx為數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
