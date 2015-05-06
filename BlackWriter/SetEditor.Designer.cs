namespace BlackWriter
{
    partial class SetEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new SingleAssemblyComponentResourceManager(typeof(SetEditor));
            this.CasesBox = new System.Windows.Forms.GroupBox();
            this.btnCaseAdd = new System.Windows.Forms.Button();
            this.btnCaseDelete = new System.Windows.Forms.Button();
            this.lbCases = new System.Windows.Forms.ListBox();
            this.EditCaseBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCaseTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaseQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCaseAnswer = new System.Windows.Forms.TextBox();
            this.CaseImageBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbAnswer = new System.Windows.Forms.PictureBox();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.setBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSetName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbSet = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSetSubtitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSetDescription = new System.Windows.Forms.TextBox();
            this.tbSetLocale = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CasesBox.SuspendLayout();
            this.EditCaseBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.CaseImageBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.setBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CasesBox
            // 
            this.CasesBox.Controls.Add(this.btnCaseAdd);
            this.CasesBox.Controls.Add(this.btnCaseDelete);
            this.CasesBox.Controls.Add(this.lbCases);
            resources.ApplyResources(this.CasesBox, "CasesBox");
            this.CasesBox.Name = "CasesBox";
            this.CasesBox.TabStop = false;
            // 
            // btnCaseAdd
            // 
            resources.ApplyResources(this.btnCaseAdd, "btnCaseAdd");
            this.btnCaseAdd.BackgroundImage = global::BlackWriter.Properties.Resources.add;
            this.btnCaseAdd.Name = "btnCaseAdd";
            this.btnCaseAdd.UseVisualStyleBackColor = true;
            this.btnCaseAdd.Click += new System.EventHandler(this.btnCaseAdd_Click);
            // 
            // btnCaseDelete
            // 
            resources.ApplyResources(this.btnCaseDelete, "btnCaseDelete");
            this.btnCaseDelete.BackgroundImage = global::BlackWriter.Properties.Resources.delete;
            this.btnCaseDelete.Name = "btnCaseDelete";
            this.btnCaseDelete.UseVisualStyleBackColor = true;
            this.btnCaseDelete.Click += new System.EventHandler(this.btnCaseDelete_Click);
            // 
            // lbCases
            // 
            resources.ApplyResources(this.lbCases, "lbCases");
            this.lbCases.FormattingEnabled = true;
            this.lbCases.Name = "lbCases";
            this.lbCases.SelectedIndexChanged += new System.EventHandler(this.lbCases_SelectedIndexChanged);
            // 
            // EditCaseBox
            // 
            this.EditCaseBox.Controls.Add(this.tableLayoutPanel5);
            resources.ApplyResources(this.EditCaseBox, "EditCaseBox");
            this.EditCaseBox.Name = "EditCaseBox";
            this.EditCaseBox.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbCaseTitle, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tbCaseQuestion, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.tbCaseAnswer, 0, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbCaseTitle
            // 
            resources.ApplyResources(this.tbCaseTitle, "tbCaseTitle");
            this.tbCaseTitle.Name = "tbCaseTitle";
            this.tbCaseTitle.TextChanged += new System.EventHandler(this.tbCaseTitle_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbCaseQuestion
            // 
            resources.ApplyResources(this.tbCaseQuestion, "tbCaseQuestion");
            this.tbCaseQuestion.Name = "tbCaseQuestion";
            this.tbCaseQuestion.TextChanged += new System.EventHandler(this.tbCaseQuestion_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbCaseAnswer
            // 
            resources.ApplyResources(this.tbCaseAnswer, "tbCaseAnswer");
            this.tbCaseAnswer.Name = "tbCaseAnswer";
            this.tbCaseAnswer.TextChanged += new System.EventHandler(this.tbCaseAnswer_TextChanged);
            // 
            // CaseImageBox
            // 
            this.CaseImageBox.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.CaseImageBox, "CaseImageBox");
            this.CaseImageBox.Name = "CaseImageBox";
            this.CaseImageBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pbAnswer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbQuestion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pbAnswer
            // 
            this.pbAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pbAnswer, "pbAnswer");
            this.pbAnswer.Image = global::BlackWriter.Properties.Resources.NoImage;
            this.pbAnswer.Name = "pbAnswer";
            this.pbAnswer.TabStop = false;
            this.pbAnswer.Click += new System.EventHandler(this.pbAnswer_Click);
            // 
            // pbQuestion
            // 
            this.pbQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pbQuestion, "pbQuestion");
            this.pbQuestion.Image = global::BlackWriter.Properties.Resources.NoImage;
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.TabStop = false;
            this.pbQuestion.Click += new System.EventHandler(this.pbQuestion_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.BackgroundImage = global::BlackWriter.Properties.Resources.save;
            resources.ApplyResources(this.btnSaveSet, "btnSaveSet");
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // setBox
            // 
            resources.ApplyResources(this.setBox, "setBox");
            this.setBox.Controls.Add(this.tableLayoutPanel2);
            this.setBox.Name = "setBox";
            this.setBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbSetName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbSet, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbSetSubtitle, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbSetDescription, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbSetLocale, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbSetName
            // 
            resources.ApplyResources(this.tbSetName, "tbSetName");
            this.tbSetName.Name = "tbSetName";
            this.tbSetName.TextChanged += new System.EventHandler(this.tbSetName_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // pbSet
            // 
            resources.ApplyResources(this.pbSet, "pbSet");
            this.pbSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSet.Image = global::BlackWriter.Properties.Resources.NoCover;
            this.pbSet.Name = "pbSet";
            this.tableLayoutPanel2.SetRowSpan(this.pbSet, 5);
            this.pbSet.TabStop = false;
            this.pbSet.Click += new System.EventHandler(this.pbSet_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbSetSubtitle
            // 
            resources.ApplyResources(this.tbSetSubtitle, "tbSetSubtitle");
            this.tbSetSubtitle.Name = "tbSetSubtitle";
            this.tbSetSubtitle.TextChanged += new System.EventHandler(this.tbSetSubtitle_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // tbSetDescription
            // 
            resources.ApplyResources(this.tbSetDescription, "tbSetDescription");
            this.tbSetDescription.Name = "tbSetDescription";
            this.tableLayoutPanel2.SetRowSpan(this.tbSetDescription, 5);
            this.tbSetDescription.TextChanged += new System.EventHandler(this.tbSetDescription_TextChanged);
            // 
            // tbSetLocale
            // 
            resources.ApplyResources(this.tbSetLocale, "tbSetLocale");
            this.tbSetLocale.FormattingEnabled = true;
            this.tbSetLocale.Items.AddRange(new object[] {
            resources.GetString("tbSetLocale.Items"),
            resources.GetString("tbSetLocale.Items1")});
            this.tbSetLocale.Name = "tbSetLocale";
            this.tbSetLocale.SelectedIndexChanged += new System.EventHandler(this.tbSetLocale_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.EditCaseBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.CaseImageBox, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.CasesBox, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.setBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSaveSet, 0, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // SetEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Icon = global::BlackWriter.Properties.Resources.favicon;
            this.Name = "SetEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetEditor_FormClosed);
            this.CasesBox.ResumeLayout(false);
            this.EditCaseBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.CaseImageBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.setBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CasesBox;
        private System.Windows.Forms.Button btnCaseAdd;
        private System.Windows.Forms.Button btnCaseDelete;
        private System.Windows.Forms.ListBox lbCases;
        private System.Windows.Forms.GroupBox EditCaseBox;
        private System.Windows.Forms.GroupBox CaseImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbAnswer;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveSet;
        private System.Windows.Forms.GroupBox setBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSetName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSetSubtitle;
        private System.Windows.Forms.TextBox tbSetDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCaseTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaseQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCaseAnswer;
        private System.Windows.Forms.ComboBox tbSetLocale;
    }
}