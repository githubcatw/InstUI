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
    public partial class Complete : Form {
        public Config cfg = new Config();
        public Strings strings = new Strings();
        public Complete() {
            InitializeComponent();
            Text = strings.title.Replace("{Product}", cfg.productName);
            BackColor = cfg.background;
            title.Text = strings.completeTitle;
            description.Text = strings.completeDescription.Replace("{Product}", cfg.productName);
            end.Text = strings.completeClose;
        }

        private void End_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Closinge(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
