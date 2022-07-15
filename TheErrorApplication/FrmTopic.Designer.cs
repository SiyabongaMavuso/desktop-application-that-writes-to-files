
namespace TheErrorApplication
{
    partial class FrmTopic
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.lblStudyDescription = new System.Windows.Forms.Label();
            this.btnLst = new System.Windows.Forms.Button();
            this.btnInsertTopic = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.txtTopicDescription = new System.Windows.Forms.TextBox();
            this.txtTopicId = new System.Windows.Forms.TextBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.lblTopicId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstTopic = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTopic);
            this.groupBox1.Controls.Add(this.lblStudyDescription);
            this.groupBox1.Controls.Add(this.btnLst);
            this.groupBox1.Controls.Add(this.btnInsertTopic);
            this.groupBox1.Controls.Add(this.btnGoHome);
            this.groupBox1.Controls.Add(this.txtTopicDescription);
            this.groupBox1.Controls.Add(this.txtTopicId);
            this.groupBox1.Controls.Add(this.lblTopicDescription);
            this.groupBox1.Controls.Add(this.lblTopicId);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Topics";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(405, 98);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(351, 29);
            this.cmbTopic.TabIndex = 1;
            this.cmbTopic.SelectedIndexChanged += new System.EventHandler(this.cmbTopic_SelectedIndexChanged);
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
            this.btnLst.Location = new System.Drawing.Point(410, 133);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(104, 28);
            this.btnLst.TabIndex = 2;
            this.btnLst.Text = "List";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // btnInsertTopic
            // 
            this.btnInsertTopic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTopic.Location = new System.Drawing.Point(652, 133);
            this.btnInsertTopic.Name = "btnInsertTopic";
            this.btnInsertTopic.Size = new System.Drawing.Size(104, 28);
            this.btnInsertTopic.TabIndex = 4;
            this.btnInsertTopic.Text = "Insert Topic";
            this.btnInsertTopic.UseVisualStyleBackColor = true;
            this.btnInsertTopic.Click += new System.EventHandler(this.btnInsertTopic_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoHome.Location = new System.Drawing.Point(532, 133);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(104, 28);
            this.btnGoHome.TabIndex = 3;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // txtTopicDescription
            // 
            this.txtTopicDescription.Location = new System.Drawing.Point(405, 63);
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.Size = new System.Drawing.Size(351, 29);
            this.txtTopicDescription.TabIndex = 0;
            // 
            // txtTopicId
            // 
            this.txtTopicId.Location = new System.Drawing.Point(405, 27);
            this.txtTopicId.Name = "txtTopicId";
            this.txtTopicId.Size = new System.Drawing.Size(351, 29);
            this.txtTopicId.TabIndex = 99;
            this.txtTopicId.TextChanged += new System.EventHandler(this.txtTopicId_TextChanged);
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicDescription.Location = new System.Drawing.Point(73, 63);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(119, 19);
            this.lblTopicDescription.TabIndex = 1;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // lblTopicId
            // 
            this.lblTopicId.AutoSize = true;
            this.lblTopicId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicId.Location = new System.Drawing.Point(73, 38);
            this.lblTopicId.Name = "lblTopicId";
            this.lblTopicId.Size = new System.Drawing.Size(66, 19);
            this.lblTopicId.TabIndex = 0;
            this.lblTopicId.Text = "Topic ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTopic);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Topic List";
            // 
            // lstTopic
            // 
            this.lstTopic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTopic.FormattingEnabled = true;
            this.lstTopic.ItemHeight = 19;
            this.lstTopic.Location = new System.Drawing.Point(18, 19);
            this.lstTopic.Name = "lstTopic";
            this.lstTopic.Size = new System.Drawing.Size(738, 175);
            this.lstTopic.TabIndex = 5;
            this.lstTopic.SelectedIndexChanged += new System.EventHandler(this.lstTopic_SelectedIndexChanged);
            // 
            // FrmTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTopic";
            this.Text = "FrmTopic";
            this.Load += new System.EventHandler(this.FrmTopic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.Button btnInsertTopic;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.TextBox txtTopicDescription;
        private System.Windows.Forms.TextBox txtTopicId;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.Label lblTopicId;
        private System.Windows.Forms.Label lblStudyDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstTopic;
        private System.Windows.Forms.ComboBox cmbTopic;
    }
}