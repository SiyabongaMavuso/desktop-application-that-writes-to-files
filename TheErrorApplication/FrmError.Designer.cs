
namespace TheErrorApplication
{
    partial class FrmError
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
            this.lstError = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStudy = new System.Windows.Forms.ComboBox();
            this.lblStudyDescription = new System.Windows.Forms.Label();
            this.btnLst = new System.Windows.Forms.Button();
            this.btnInsertError = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.txtErrorDescription = new System.Windows.Forms.TextBox();
            this.txtErrorId = new System.Windows.Forms.TextBox();
            this.lblErrorDescription = new System.Windows.Forms.Label();
            this.lblErrorId = new System.Windows.Forms.Label();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstError);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 172);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error List";
            // 
            // lstError
            // 
            this.lstError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstError.FormattingEnabled = true;
            this.lstError.ItemHeight = 19;
            this.lstError.Location = new System.Drawing.Point(18, 28);
            this.lstError.Name = "lstError";
            this.lstError.Size = new System.Drawing.Size(738, 137);
            this.lstError.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblErrorDate);
            this.groupBox1.Controls.Add(this.cmbTopic);
            this.groupBox1.Controls.Add(this.lblTopicDescription);
            this.groupBox1.Controls.Add(this.cmbStudy);
            this.groupBox1.Controls.Add(this.lblStudyDescription);
            this.groupBox1.Controls.Add(this.btnLst);
            this.groupBox1.Controls.Add(this.btnInsertError);
            this.groupBox1.Controls.Add(this.btnGoHome);
            this.groupBox1.Controls.Add(this.txtErrorDescription);
            this.groupBox1.Controls.Add(this.txtErrorId);
            this.groupBox1.Controls.Add(this.lblErrorDescription);
            this.groupBox1.Controls.Add(this.lblErrorId);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Information";
            // 
            // cmbStudy
            // 
            this.cmbStudy.FormattingEnabled = true;
            this.cmbStudy.Location = new System.Drawing.Point(405, 98);
            this.cmbStudy.Name = "cmbStudy";
            this.cmbStudy.Size = new System.Drawing.Size(351, 29);
            this.cmbStudy.TabIndex = 1;
            // 
            // lblStudyDescription
            // 
            this.lblStudyDescription.AutoSize = true;
            this.lblStudyDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyDescription.Location = new System.Drawing.Point(73, 99);
            this.lblStudyDescription.Name = "lblStudyDescription";
            this.lblStudyDescription.Size = new System.Drawing.Size(120, 19);
            this.lblStudyDescription.TabIndex = 101;
            this.lblStudyDescription.Text = "Study Description:";
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst.Location = new System.Drawing.Point(405, 210);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(104, 28);
            this.btnLst.TabIndex = 4;
            this.btnLst.Text = "List";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // btnInsertError
            // 
            this.btnInsertError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertError.Location = new System.Drawing.Point(647, 210);
            this.btnInsertError.Name = "btnInsertError";
            this.btnInsertError.Size = new System.Drawing.Size(104, 28);
            this.btnInsertError.TabIndex = 6;
            this.btnInsertError.Text = "Insert Error";
            this.btnInsertError.UseVisualStyleBackColor = true;
            this.btnInsertError.Click += new System.EventHandler(this.btnInsertError_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoHome.Location = new System.Drawing.Point(527, 210);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(104, 28);
            this.btnGoHome.TabIndex = 5;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // txtErrorDescription
            // 
            this.txtErrorDescription.Location = new System.Drawing.Point(405, 63);
            this.txtErrorDescription.Name = "txtErrorDescription";
            this.txtErrorDescription.Size = new System.Drawing.Size(351, 29);
            this.txtErrorDescription.TabIndex = 0;
            // 
            // txtErrorId
            // 
            this.txtErrorId.Location = new System.Drawing.Point(405, 27);
            this.txtErrorId.Name = "txtErrorId";
            this.txtErrorId.Size = new System.Drawing.Size(351, 29);
            this.txtErrorId.TabIndex = 99;
            // 
            // lblErrorDescription
            // 
            this.lblErrorDescription.AutoSize = true;
            this.lblErrorDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescription.Location = new System.Drawing.Point(73, 63);
            this.lblErrorDescription.Name = "lblErrorDescription";
            this.lblErrorDescription.Size = new System.Drawing.Size(117, 19);
            this.lblErrorDescription.TabIndex = 1;
            this.lblErrorDescription.Text = "Error Description:";
            // 
            // lblErrorId
            // 
            this.lblErrorId.AutoSize = true;
            this.lblErrorId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorId.Location = new System.Drawing.Point(73, 38);
            this.lblErrorId.Name = "lblErrorId";
            this.lblErrorId.Size = new System.Drawing.Size(64, 19);
            this.lblErrorId.TabIndex = 0;
            this.lblErrorId.Text = "Error ID:";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(405, 132);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(351, 29);
            this.cmbTopic.TabIndex = 2;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicDescription.Location = new System.Drawing.Point(73, 133);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(119, 19);
            this.lblTopicDescription.TabIndex = 103;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.AutoSize = true;
            this.lblErrorDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDate.Location = new System.Drawing.Point(73, 169);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(77, 19);
            this.lblErrorDate.TabIndex = 104;
            this.lblErrorDate.Text = "Error Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(405, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(351, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmError";
            this.Text = "FrmError";
            this.Load += new System.EventHandler(this.FrmError_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblErrorDate;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.ComboBox cmbStudy;
        private System.Windows.Forms.Label lblStudyDescription;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.Button btnInsertError;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.TextBox txtErrorDescription;
        private System.Windows.Forms.TextBox txtErrorId;
        private System.Windows.Forms.Label lblErrorDescription;
        private System.Windows.Forms.Label lblErrorId;
    }
}