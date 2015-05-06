using System;
using System.IO;
using System.Windows.Forms;

namespace BlackWriter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetEditor editor = new SetEditor();
            editor.Show();
            Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();


            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                var path = folderDialog.SelectedPath;
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("Verzeichniss nicht gefunden!");
                    return;
                }

                if (File.Exists(Path.Combine(path, "CardGame.plist")) &&
                    File.Exists(Path.Combine(path, "Settings.plist")))
                {
                    SetEditor editor = new SetEditor(path);
                    editor.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Daten nicht vollständig!");
                }
            }
        }
    }
}
