using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBar
{
    public partial class RunBar : Form
    {
        public RunBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Windows\System32\cmd.exe");
        }

        private void taskmgr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Windows\System32\taskmgr.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\Q-Dir\Q-Dir.exe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\bootice.exe");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\find.exe");
        }

        private void gimagex_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\gimagex.exe");
        }

        private void nsudo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\NSudo\NSudo.bat");
        }

        private void zip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\7-Zip\7zFM.exe");
        }

        private void fastcopy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\FastCopy\FastCopy.exe");
        }

        private void notepad2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\note.exe");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo shutdownP = new System.Diagnostics.ProcessStartInfo();
            shutdownP.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            shutdownP.FileName = "wpeutil.exe";
            shutdownP.Arguments = "Shutdown";
            System.Diagnostics.Process.Start(shutdownP);
        }

        private void reboot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo rebootP = new System.Diagnostics.ProcessStartInfo();
            rebootP.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            rebootP.FileName = "wpeutil.exe";
            rebootP.Arguments = "Reboot";
            System.Diagnostics.Process.Start(rebootP);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\datarecovery\DRW0.exe");
        }

        private void partassist_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"X:\Tools\PartAssist\PartAssist.exe");
        }
    }
}
