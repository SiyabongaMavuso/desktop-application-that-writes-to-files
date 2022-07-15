
namespace TheErrorApplication
{
    partial class FrmSolution
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSolution = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSolutionDate = new System.Windows.Forms.Label();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.cmbStudy = new System.Windows.Forms.ComboBox();
            this.lblStudyDescription = new System.Windows.Forms.Label();
            this.btnLst = new System.Windows.Forms.Button();
            this.btnInsertSolution = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.txtSolutionDescription = new System.Windows.Forms.TextBox();
            this.txtSolutionId = new System.Windows.Forms.TextBox();
            this.lblErrorDescription = new System.Windows.Forms.Label();
            this.lblErrorId = new System.Windows.Forms.Label();
            this.cmbError = new System.Windows.Forms.ComboBox();
            this.lblEDescription = new System.Windows.Forms.Label();
            this.lblNoSolution = new System.Windows.Forms.Label();
            this.lblNoSolutions = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNoSolutions);
            this.groupBox2.Controls.Add(this.lblNoSolution);
            this.groupBox2.Controls.Add(this.lstSolution);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 175);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solutions List";
            // 
            // lstSolution
            // 
            this.lstSolution.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSolution.FormattingEnabled = true;
            this.lstSolution.ItemHeight = 19;
            this.lstSolution.Location = new System.Drawing.Point(18, 28);
            this.lstSolution.Name = "lstSolution";
            this.lstSolution.Size = new System.Drawing.Size(738, 99);
            this.lstSolution.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbError);
            this.groupBox1.Controls.Add(this.lblEDescription);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblSolutionDate);
            this.groupBox1.Controls.Add(this.cmbTopic);
            this.groupBox1.Controls.Add(this.lblTopicDescription);
            this.groupBox1.Controls.Add(this.cmbStudy);
            this.groupBox1.Controls.Add(this.lblStudyDescription);
            this.groupBox1.Controls.Add(this.btnLst);
            this.groupBox1.Controls.Add(this.btnInsertSolution);
            this.groupBox1.Controls.Add(this.btnGoHome);
            this.groupBox1.Controls.Add(this.txtSolutionDescription);
            this.groupBox1.Controls.Add(this.txtSolutionId);
            this.groupBox1.Controls.Add(this.lblErrorDescription);
            this.groupBox1.Controls.Add(this.lblErrorId);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(405, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(351, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblSolutionDate
            // 
            this.lblSolutionDate.AutoSize = true;
            this.lblSolutionDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionDate.Location = new System.Drawing.Point(73, 201);
            this.lblSolutionDate.Name = "lblSolutionDate";
            this.lblSolutionDate.Size = new System.Drawing.Size(94, 19);
            this.lblSolutionDate.TabIndex = 104;
            this.lblSolutionDate.Text = "Solution Date:";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(405, 164);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(351, 29);
            this.cmbTopic.TabIndex = 2;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicDescription.Location = new System.Drawing.Point(73, 165);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(119, 19);
            this.lblTopicDescription.TabIndex = 103;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // cmbStudy
            // 
            this.cmbStudy.FormattingEnabled = true;
            this.cmbStudy.Location = new System.Drawing.Point(405, 130);
            this.cmbStudy.Name = "cmbStudy";
            this.cmbStudy.Size = new System.Drawing.Size(351, 29);
            this.cmbStudy.TabIndex = 1;
            // 
            // lblStudyDescription
            // 
            this.lblStudyDescription.AutoSize = true;
            this.lblStudyDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyDescription.Location = new System.Drawing.Point(73, 131);
            this.lblStudyDescription.Name = "lblStudyDescription";
            this.lblStudyDescription.Size = new System.Drawing.Size(120, 19);
            this.lblStudyDescription.TabIndex = 101;
            this.lblStudyDescription.Text = "Study Description:";
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst.Location = new System.Drawing.Point(405, 235);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(104, 28);
            this.btnLst.TabIndex = 4;
            this.btnLst.Text = "List";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // btnInsertSolution
            // 
            this.btnInsertSolution.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertSolution.Location = new System.Drawing.Point(647, 235);
            this.btnInsertSolution.Name = "btnInsertSolution";
            this.btnInsertSolution.Size = new System.Drawing.Size(104, 28);
            this.btnInsertSolution.TabIndex = 6;
            this.btnInsertSolution.Text = "Insert Solution";
            this.btnInsertSolution.UseVisualStyleBackColor = true;
            this.btnInsertSolution.Click += new System.EventHandler(this.btnInsertSolution_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoHome.Location = new System.Drawing.Point(527, 235);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(104, 28);
            this.btnGoHome.TabIndex = 5;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // txtSolutionDescription
            // 
            this.txtSolutionDescription.Location = new System.Drawing.Point(405, 63);
            this.txtSolutionDescription.Name = "txtSolutionDescription";
            this.txtSolutionDescription.Size = new System.Drawing.Size(351, 29);
            this.txtSolutionDescription.TabIndex = 0;
            // 
            // txtSolutionId
            // 
            this.txtSolutionId.Location = new System.Drawing.Point(405, 27);
            this.txtSolutionId.Name = "txtSolutionId";
            this.txtSolutionId.Size = new System.Drawing.Size(351, 29);
            this.txtSolutionId.TabIndex = 99;
            // 
            // lblErrorDescription
            // 
            this.lblErrorDescription.AutoSize = true;
            this.lblErrorDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescription.Location = new System.Drawing.Point(73, 67);
            this.lblErrorDescription.Name = "lblErrorDescription";
            this.lblErrorDescription.Size = new System.Drawing.Size(134, 19);
            this.lblErrorDescription.TabIndex = 1;
            this.lblErrorDescription.Text = "Solution Description:";
            // 
            // lblErrorId
            // 
            this.lblErrorId.AutoSize = true;
            this.lblErrorId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorId.Location = new System.Drawing.Point(73, 37);
            this.lblErrorId.Name = "lblErrorId";
            this.lblErrorId.Size = new System.Drawing.Size(64, 19);
            this.lblErrorId.TabIndex = 0;
            this.lblErrorId.Text = "Error ID:";
            // 
            // cmbError
            // 
            this.cmbError.FormattingEnabled = true;
            this.cmbError.Location = new System.Drawing.Point(405, 98);
            this.cmbError.Name = "cmbError";
            this.cmbError.Size = new System.Drawing.Size(351, 29);
            this.cmbError.TabIndex = 105;
            // 
            // lblEDescription
            // 
            this.lblEDescription.AutoSize = true;
            this.lblEDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDescription.Location = new System.Drawing.Point(73, 99);
            this.lblEDescription.Name = "lblEDescription";
            this.lblEDescription.Size = new System.Drawing.Size(117, 19);
            this.lblEDescription.TabIndex = 106;
            this.lblEDescription.Text = "Error Description:";
            // 
            // lblNoSolution
            // 
            this.lblNoSolution.AutoSize = true;
            this.lblNoSolution.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSolution.Location = new System.Drawing.Point(75, 139);
            this.lblNoSolution.Name = "lblNoSolution";
            this.lblNoSolution.Size = new System.Drawing.Size(137, 19);
            this.lblNoSolution.TabIndex = 105;
            this.lblNoSolution.Text = "Number of Solutions:";
            // 
            // lblNoSolutions
            // 
            this.lblNoSolutions.AutoSize = true;
            this.lblNoSolutions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSolutions.Location = new System.Drawing.Point(736, 139);
            this.lblNoSolutions.Name = "lblNoSolutions";
            this.lblNoSolutions.Size = new System.Drawing.Size(17, 19);
            this.lblNoSolutions.TabIndex = 106;
            this.lblNoSolutions.Text = "0";
            // 
            // FrmSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSolution";
            this.Text = "FrmSolution";
            this.Load += new System.EventHandler(this.FrmSolution_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSolution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSolutionDate;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.ComboBox cmbStudy;
        private System.Windows.Forms.Label lblStudyDescription;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.Button btnInsertSolution;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.TextBox txtSolutionDescription;
        private System.Windows.Forms.TextBox txtSolutionId;
        private System.Windows.Forms.Label lblErrorDescription;
        private System.Windows.Forms.Label lblErrorId;
        private System.Windows.Forms.ComboBox cmbError;
        private System.Windows.Forms.Label lblEDescription;
        private System.Windows.Forms.Label lblNoSolutions;
        private System.Windows.Forms.Label lblNoSolution;
    }
}