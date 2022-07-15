
namespace TheErrorApplication
{
    partial class FrmStudy
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
            this.btnLst = new System.Windows.Forms.Button();
            this.btnInsertYear = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.lstStudyLevel = new System.Windows.Forms.ListBox();
            this.txtStudyDescription = new System.Windows.Forms.TextBox();
            this.txtStudyId = new System.Windows.Forms.TextBox();
            this.lblStudyDescription = new System.Windows.Forms.Label();
            this.lblStudyId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLst);
            this.groupBox1.Controls.Add(this.btnInsertYear);
            this.groupBox1.Controls.Add(this.btnGoHome);
            this.groupBox1.Controls.Add(this.lstStudyLevel);
            this.groupBox1.Controls.Add(this.txtStudyDescription);
            this.groupBox1.Controls.Add(this.txtStudyId);
            this.groupBox1.Controls.Add(this.lblStudyDescription);
            this.groupBox1.Controls.Add(this.lblStudyId);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Level Information";
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst.Location = new System.Drawing.Point(318, 207);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(104, 28);
            this.btnLst.TabIndex = 3;
            this.btnLst.Text = "List";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // btnInsertYear
            // 
            this.btnInsertYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertYear.Location = new System.Drawing.Point(318, 150);
            this.btnInsertYear.Name = "btnInsertYear";
            this.btnInsertYear.Size = new System.Drawing.Size(104, 28);
            this.btnInsertYear.TabIndex = 2;
            this.btnInsertYear.Text = "Insert Year";
            this.btnInsertYear.UseVisualStyleBackColor = true;
            this.btnInsertYear.Click += new System.EventHandler(this.btnInsertYear_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoHome.Location = new System.Drawing.Point(198, 150);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(104, 28);
            this.btnGoHome.TabIndex = 1;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // lstStudyLevel
            // 
            this.lstStudyLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudyLevel.FormattingEnabled = true;
            this.lstStudyLevel.ItemHeight = 19;
            this.lstStudyLevel.Location = new System.Drawing.Point(439, 30);
            this.lstStudyLevel.Name = "lstStudyLevel";
            this.lstStudyLevel.Size = new System.Drawing.Size(323, 270);
            this.lstStudyLevel.TabIndex = 4;
            // 
            // txtStudyDescription
            // 
            this.txtStudyDescription.Location = new System.Drawing.Point(198, 72);
            this.txtStudyDescription.Name = "txtStudyDescription";
            this.txtStudyDescription.Size = new System.Drawing.Size(224, 29);
            this.txtStudyDescription.TabIndex = 0;
            // 
            // txtStudyId
            // 
            this.txtStudyId.Location = new System.Drawing.Point(198, 28);
            this.txtStudyId.Name = "txtStudyId";
            this.txtStudyId.Size = new System.Drawing.Size(224, 29);
            this.txtStudyId.TabIndex = 99;
            this.txtStudyId.TextChanged += new System.EventHandler(this.txtStudyId_TextChanged);
            // 
            // lblStudyDescription
            // 
            this.lblStudyDescription.AutoSize = true;
            this.lblStudyDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyDescription.Location = new System.Drawing.Point(14, 82);
            this.lblStudyDescription.Name = "lblStudyDescription";
            this.lblStudyDescription.Size = new System.Drawing.Size(120, 19);
            this.lblStudyDescription.TabIndex = 1;
            this.lblStudyDescription.Text = "Study Description:";
            // 
            // lblStudyId
            // 
            this.lblStudyId.AutoSize = true;
            this.lblStudyId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyId.Location = new System.Drawing.Point(14, 38);
            this.lblStudyId.Name = "lblStudyId";
            this.lblStudyId.Size = new System.Drawing.Size(67, 19);
            this.lblStudyId.TabIndex = 0;
            this.lblStudyId.Text = "Study ID:";
            // 
            // FrmStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudy";
            this.Text = "FrmStudy";
            this.Load += new System.EventHandler(this.FrmStudy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.Button btnInsertYear;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.ListBox lstStudyLevel;
        private System.Windows.Forms.TextBox txtStudyDescription;
        private System.Windows.Forms.TextBox txtStudyId;
        private System.Windows.Forms.Label lblStudyDescription;
        private System.Windows.Forms.Label lblStudyId;
    }
}