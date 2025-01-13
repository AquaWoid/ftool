using ftool.Handlers;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftool
{
    public partial class UI : Form
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        ProcessManager pm = new ProcessManager();

        public UI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = pm.getWindowNames();
            windowName1.DataSource = bs;
            KeyCbo1.SelectedIndex = 0;
        }

        private void toggleUI(bool active)
        {
            if (active)
            {
                windowName1.Enabled = true;
                KeyCbo1.Enabled = true;
                txtDelay1.Enabled = true;
                fKeyCheckBox.Enabled = true;
            }
            else
            {
                windowName1.Enabled = false;
                KeyCbo1.Enabled = false;
                txtDelay1.Enabled = false;
                fKeyCheckBox.Enabled = false;
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                toggleUI(false);
                string windowname = windowName1.Text;
                int keyInt = int.Parse(KeyCbo1.Text);
                bool isActive = checkBox1.Checked;
                bool fMode = fKeyCheckBox.Checked;

                cancellationTokenSource = new CancellationTokenSource();

                Task.Run(() => pm.spamLoop(windowname, keyInt, int.Parse(txtDelay1.Text), cancellationTokenSource.Token, fMode));
            }
            else {
                toggleUI(true);
                cancellationTokenSource?.Cancel();
            }
        }
    }
}
