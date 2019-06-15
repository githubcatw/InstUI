using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstUI {
    public partial class Install : Form {
        public Config cfg = new Config();
        public Strings strings = new Strings();

        public void wait(int milliseconds) {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled) {
                Application.DoEvents();
            }
        }

        public Install() {
            InitializeComponent();
            Text = strings.title.Replace("{Product}", cfg.productName);
            BackColor = cfg.background;
            title.Text = strings.installTitle;
            description.Text = strings.installDescription.Replace("{Product}", cfg.productName);
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e) {
            var temp = Path.GetTempFileName() + ".exe";
            File.WriteAllBytes(temp, Properties.Resources.Installer);
            Process execute = new Process();
            execute.StartInfo.FileName = temp;
            execute.StartInfo.Arguments = Installer.silent[cfg.instType];
            execute.Start();
            execute.WaitForExit();
            execute.Dispose();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            Complete nextForm = new Complete();
            nextForm.Show();
            this.Hide();
        }
    }
}
