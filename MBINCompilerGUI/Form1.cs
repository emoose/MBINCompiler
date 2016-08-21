using System.Diagnostics;
using System.Windows.Forms;

namespace MBINCompilerGUI
{
    public partial class MBINCompilerGUI : Form
    {
        public MBINCompilerGUI()
        {
            InitializeComponent();
        }
        private void runComp(string file)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "MBINCompiler.exe",
                    Arguments = '"'+file+'"',
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            try
            {
                proc.Start();
            } catch
            {
                outputBox.Text = "Cannot find MBINCompiler.exe";
            }
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine() + "\n";
                outputBox.Text += line;
            }
            proc.Close();
        }

        private void fileDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                //Console.WriteLine(file);
                outputBox.Text += "\n\nSending: " + file;
                runComp(file);
            }
        }

        private void fileDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
    }
}
