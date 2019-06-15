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
    public partial class License : Form {
        public Config cfg = new Config();
        public Strings strings = new Strings();
        string txt;
        public License() {
            InitializeComponent();
            Text = strings.title.Replace("{Product}", cfg.productName);
            BackColor = cfg.background;
            title.Text = strings.licenseTitle;
            description.Text = strings.licenseDescription.Replace("{Product}", cfg.productName);
            agree.Text = strings.licenseAccept;
            decline.Text = strings.licenseDecline;
            txt = Properties.Resources.License;
            richTextBox1.Text = txt;
        }

        private void Agree_Click(object sender, EventArgs e) {
            Install nextForm = new Install();
            nextForm.Show();
            this.Hide();
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            string message = "Setup will now close.";
            string title = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                this.Close();
            }
            else {
                // Do something  
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = txt;

        }
    }
}
