using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstUI {
    public partial class Welcome : Form {
        public Config cfg = new Config();
        public Strings strings = new Strings();
        public Welcome() {
            InitializeComponent();
            Text = strings.title.Replace("{Product}", cfg.productName);
            BackColor = cfg.background;
            title.Text = strings.welcomeTitle;
            description.Text = strings.welcomeDescription.Replace("{Product}", cfg.productName);
            next.Text = strings.welcomeBtn;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            License nextForm = new License();
            nextForm.Show();
            this.Hide();
        }

        private void Closinge(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
