using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BlackWriter
{
    public partial class SetEditor : Form
    {
        private readonly Set _set;
        private Case _selectedCase;

        public SetEditor()
        {
            InitializeComponent();
            _set = new Set();
        }

        public SetEditor(string folder)
        {
            InitializeComponent();
            _set = new Set(folder);
            Init();
        }

        private void Init()
        {
            tbSetName.Text = _set.EditionName;
            tbSetDescription.Text = _set.DetailDescription;
            tbSetSubtitle.Text = _set.Subtitle;
            tbSetLocale.Text = _set.Locale;

            pbSet.Image = _set.Cover ?? Properties.Resources.NoCover;

            foreach (var c in _set.Cases)
            {
                lbCases.Items.Add(c);
            }

            if (lbCases.Items.Count > 0)
            {
                lbCases.SelectedIndex = 0;
            }
        }

        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();


            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                var path = folderDialog.SelectedPath;
                if (!Directory.Exists(path))
                {
                    MessageBox.Show(strings.folderNotFound);
                    return;
                }

                var savedPath = _set.Export(path);

                if (!String.IsNullOrEmpty(savedPath))
                {

                    ProcessStartInfo psInfo = new ProcessStartInfo("explorer.exe",
                        string.Format("/Select, \"{0}\"", savedPath));
                    Process.Start(psInfo);
                }
            }
        }

        private void SetEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            pbSet.Dispose();
            pbAnswer.Dispose();
            pbQuestion.Dispose();
            _set.Dispose();
            Application.Exit();
        }

        private void tbSetName_TextChanged(object sender, EventArgs e)
        {
            _set.EditionName = tbSetName.Text.Trim();
        }

        private void tbSetSubtitle_TextChanged(object sender, EventArgs e)
        {
            _set.Subtitle = tbSetSubtitle.Text.Trim();
        }
      

        private void tbSetDescription_TextChanged(object sender, EventArgs e)
        {
            _set.DetailDescription = tbSetDescription.Text.Trim();
        }

        private void lbCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCases.SelectedIndex == -1)
            {
                _selectedCase = null;
                tbCaseTitle.Text = "";
                tbCaseQuestion.Text = "";
                tbCaseAnswer.Text = "";
                EditCaseBox.Enabled = false;
                CaseImageBox.Enabled = false;
            }
            else
            {
                _selectedCase = (Case)lbCases.SelectedItem;
                tbCaseTitle.Text = _selectedCase.Title;
                tbCaseQuestion.Text = _selectedCase.Question;
                tbCaseAnswer.Text = _selectedCase.Answer;
                pbQuestion.Image = _selectedCase.QuestionImage ?? Properties.Resources.NoImage; ;
                pbAnswer.Image = _selectedCase.AnswerImage ?? Properties.Resources.NoImage;
                EditCaseBox.Enabled = true;
                CaseImageBox.Enabled = true;
            }
        }

        private void btnCaseAdd_Click(object sender, EventArgs e)
        {
            lbCases.Items.Add(_set.CreateAndAddNewCase());
            lbCases.SelectedIndex = lbCases.Items.Count - 1;
        }

        private void btnCaseDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCase == null)
            {
                return;
            }

            Case caseToRemove = _selectedCase;
            _set.RemoveCase(caseToRemove);

            if (lbCases.Items.Count > 1)
            {
                int newSelected = lbCases.SelectedIndex - 1;
                if (newSelected < 0)
                {
                    newSelected = 1;
                }

                lbCases.SelectedIndex = newSelected;
            }

            lbCases.Items.Remove(caseToRemove);
        }

        private void tbCaseTitle_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCase != null)
            {
                _selectedCase.Title = tbCaseTitle.Text.Trim();
                lbCases.DisplayMember = "";
                lbCases.DisplayMember = "Name";
            }
            else
            {
                tbCaseTitle.Text = "";
            }
        }

        private void tbCaseQuestion_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCase != null)
            {
                _selectedCase.Question = tbCaseQuestion.Text.Trim();
            }
            else
            {
                tbCaseQuestion.Text = "";
            }
        }

        private void tbCaseAnswer_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCase != null)
            {
                _selectedCase.Answer = tbCaseAnswer.Text.Trim();
            }
            else
            {
                tbCaseAnswer.Text = "";
            }
        }

        private void pbSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = strings.loadCoverPicture;
            dlg.Filter = @"png files (*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbSet.Image.Dispose();
                pbSet.Image = null;
                Image image = new Bitmap(dlg.OpenFile());
                _set.Cover = image;
                pbSet.Image = _set.Cover ?? Properties.Resources.NoCover;
            }

            dlg.Dispose();
        }

        private void pbQuestion_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = strings.loadQuestionPicture;
            dlg.Filter = @"png files (*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {


                Image image = new Bitmap(dlg.OpenFile());
                if (_selectedCase != null)
                {
                    pbQuestion.Image.Dispose();
                    pbQuestion.Image = null;
                    _selectedCase.QuestionImage = image;
                    pbQuestion.Image = _selectedCase.QuestionImage ?? Properties.Resources.NoImage;
                }
            }

            dlg.Dispose();
        }

        private void pbAnswer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = strings.loadAnswerPicture;
            dlg.Filter = @"png files (*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                Image image = new Bitmap(dlg.OpenFile());

                if (_selectedCase != null)
                {
                    pbAnswer.Image.Dispose();
                    pbAnswer.Image = null;
                    _selectedCase.AnswerImage = image;
                    pbAnswer.Image = _selectedCase.AnswerImage ?? Properties.Resources.NoImage;
                }
            }

            dlg.Dispose();
        }

        private void tbSetLocale_SelectedIndexChanged(object sender, EventArgs e)
        {
            _set.Locale = tbSetLocale.Text.Trim();
        }

    }
}
