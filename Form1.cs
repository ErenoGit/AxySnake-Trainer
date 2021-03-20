using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxySnake_Trainer
{
    public partial class Form1 : Form
    {
        bool IsProcessLoaded = false;
        public Mem Memory = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void openGame()
        {
            if (IsProcessLoaded)
                return;

            bool gameProc = Memory.OpenProcess("AxySnake");

            //if OpenProcess success then gameProc is true
            if (gameProc)
            {
                IsProcessLoaded = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //infinity loop
            while (true)
            {
                Thread.Sleep(200);

                //connect to process if started
                openGame();

                //if process not started and connected
                if (!IsProcessLoaded)
                    continue;

                //if process started and connected
                GameProcessStatus.Invoke(new MethodInvoker(delegate
                {
                    GameProcessStatus.Text = "STARTED!";
                    GameProcessStatus.ForeColor = Color.DarkGreen;
                    HPText.Visible = true;
                    HPSet.Visible = true;
                    ScoreText.Visible = true;
                    ScoreSet.Visible = true;
                }));


            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Start background worker
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void GitHubProjectLink_Click(object sender, EventArgs e)
        {
            //open browser with GitHub project URL
            System.Diagnostics.Process.Start("https://github.com/ErenoGit/AxySnake-Trainer");
        }

        private void HPSet_Click(object sender, EventArgs e)
        {
            //set HP
            Memory.WriteMemory("base+78750", "int", HPText.Text.ToString());        
        }

        private void ScoreSet_Click(object sender, EventArgs e)
        {
            //set score
            Memory.WriteMemory("base+78754", "int", ScoreText.Text.ToString());
        }
    }
}
