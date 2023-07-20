namespace WebBrows6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblDestonationPath = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSelectPDFFile = new System.Windows.Forms.Label();
            this.btnCopyText = new System.Windows.Forms.Button();
            this.lblN1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(6, 0);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1170, 623);
            this.axAcroPDF1.TabIndex = 40;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSelect.Location = new System.Drawing.Point(14, 2);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(152, 39);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select file :";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(14, 91);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Encrypt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("CordiaUPC", 18F);
            this.btnOpen.Location = new System.Drawing.Point(1028, 30);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(148, 27);
            this.btnOpen.TabIndex = 30;
            this.btnOpen.Text = "Open folder";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPassword.Location = new System.Drawing.Point(41, 50);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 34);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Set Password :";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPath.ForeColor = System.Drawing.Color.Purple;
            this.txtPath.Location = new System.Drawing.Point(1028, 1);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(148, 25);
            this.txtPath.TabIndex = 60;
            this.txtPath.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPass.Location = new System.Drawing.Point(173, 51);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(211, 30);
            this.txtPass.TabIndex = 2;
            this.txtPass.WordWrap = false;
            // 
            // lblDestonationPath
            // 
            this.lblDestonationPath.AutoSize = true;
            this.lblDestonationPath.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDestonationPath.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDestonationPath.ForeColor = System.Drawing.Color.White;
            this.lblDestonationPath.Location = new System.Drawing.Point(174, 94);
            this.lblDestonationPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestonationPath.Name = "lblDestonationPath";
            this.lblDestonationPath.Size = new System.Drawing.Size(98, 34);
            this.lblDestonationPath.TabIndex = 8;
            this.lblDestonationPath.Text = "File location";
            this.lblDestonationPath.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(26, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCopyText);
            this.splitContainer1.Panel1.Controls.Add(this.lblDestonationPath);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            this.splitContainer1.Panel1.Controls.Add(this.lblSelectPDFFile);
            this.splitContainer1.Panel1.Controls.Add(this.txtPath);
            this.splitContainer1.Panel1.Controls.Add(this.txtPass);
            this.splitContainer1.Panel1.Controls.Add(this.lblPassword);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axAcroPDF1);
            this.splitContainer1.Size = new System.Drawing.Size(1196, 737);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 10;
            // 
            // lblSelectPDFFile
            // 
            this.lblSelectPDFFile.AutoSize = true;
            this.lblSelectPDFFile.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSelectPDFFile.Font = new System.Drawing.Font("CordiaUPC", 18F);
            this.lblSelectPDFFile.ForeColor = System.Drawing.Color.White;
            this.lblSelectPDFFile.Location = new System.Drawing.Point(173, 5);
            this.lblSelectPDFFile.Name = "lblSelectPDFFile";
            this.lblSelectPDFFile.Size = new System.Drawing.Size(113, 34);
            this.lblSelectPDFFile.TabIndex = 9;
            this.lblSelectPDFFile.Text = "SelectPDFFile";
            this.lblSelectPDFFile.Visible = false;
            // 
            // btnCopyText
            // 
            this.btnCopyText.Location = new System.Drawing.Point(389, 50);
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(104, 31);
            this.btnCopyText.TabIndex = 61;
            this.btnCopyText.Text = "<< copy text";
            this.btnCopyText.UseVisualStyleBackColor = true;
            this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblN1.Location = new System.Drawing.Point(8, 14);
            this.lblN1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(28, 34);
            this.lblN1.TabIndex = 62;
            this.lblN1.Text = "1.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 34);
            this.label1.TabIndex = 63;
            this.label1.Text = "2.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CordiaUPC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 34);
            this.label2.TabIndex = 64;
            this.label2.Text = "3.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1250, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF File Password Protection";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblDestonationPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSelectPDFFile;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

