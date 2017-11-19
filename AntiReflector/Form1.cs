using System;
using System.IO;
using System.Windows.Forms;

namespace AntiReflector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = ".exe|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbFile.Text = open.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbFile.Text != "" && tbFile.Text != String.Empty)
            {
                using (var save = new SaveFileDialog())
                {
                    save.Filter = ".exe|*.exe";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        using (var fs = new FileStream(save.FileName, FileMode.OpenOrCreate))
                        {
                            byte[] file = File.ReadAllBytes(tbFile.Text);
                            fs.Seek(264L, SeekOrigin.Begin);
                            fs.WriteByte(11);
                            fs.Write(file, 0, file.Length);
                            fs.Flush();
                        }
                    }
                }
                MessageBox.Show("Done )", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
