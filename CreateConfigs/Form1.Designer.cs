namespace CreateConfigs
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
            this.Rb_en = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGenerate_Profiles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtIndustry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gb_LoadFile = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Txt_PathFile = new System.Windows.Forms.TextBox();
            this.Lnk_File_Created = new System.Windows.Forms.LinkLabel();
            this.Lbl_Profiles_Created = new System.Windows.Forms.Label();
            this.Gb_Configs = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Gb_LoadFile.SuspendLayout();
            this.Gb_Configs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rb_en
            // 
            this.Rb_en.AutoSize = true;
            this.Rb_en.Checked = true;
            this.Rb_en.Location = new System.Drawing.Point(4, 17);
            this.Rb_en.Margin = new System.Windows.Forms.Padding(2);
            this.Rb_en.Name = "Rb_en";
            this.Rb_en.Size = new System.Drawing.Size(59, 17);
            this.Rb_en.TabIndex = 2;
            this.Rb_en.TabStop = true;
            this.Rb_en.Text = "English";
            this.Rb_en.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.Rb_en);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(124, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 85);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Italiano";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 63);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Deutsch";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 40);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Español";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(155, 40);
            this.TxtRole.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(193, 20);
            this.TxtRole.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGenerate_Profiles
            // 
            this.BtnGenerate_Profiles.Location = new System.Drawing.Point(629, 96);
            this.BtnGenerate_Profiles.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerate_Profiles.Name = "BtnGenerate_Profiles";
            this.BtnGenerate_Profiles.Size = new System.Drawing.Size(73, 47);
            this.BtnGenerate_Profiles.TabIndex = 8;
            this.BtnGenerate_Profiles.Text = "Generate Profiles";
            this.BtnGenerate_Profiles.UseVisualStyleBackColor = true;
            this.BtnGenerate_Profiles.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Terms});
            this.dataGridView1.Location = new System.Drawing.Point(155, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(182, 144);
            this.dataGridView1.TabIndex = 9;
            // 
            // Terms
            // 
            this.Terms.Frozen = true;
            this.Terms.HeaderText = "Role Terms";
            this.Terms.MinimumWidth = 6;
            this.Terms.Name = "Terms";
            this.Terms.ReadOnly = true;
            this.Terms.Width = 190;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(394, 110);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(182, 144);
            this.dataGridView2.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Industry Terms";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 190;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 19);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtIndustry
            // 
            this.TxtIndustry.Location = new System.Drawing.Point(394, 40);
            this.TxtIndustry.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIndustry.Name = "TxtIndustry";
            this.TxtIndustry.Size = new System.Drawing.Size(183, 20);
            this.TxtIndustry.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Industries";
            // 
            // Gb_LoadFile
            // 
            this.Gb_LoadFile.Controls.Add(this.button4);
            this.Gb_LoadFile.Controls.Add(this.Txt_PathFile);
            this.Gb_LoadFile.Location = new System.Drawing.Point(42, 24);
            this.Gb_LoadFile.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_LoadFile.Name = "Gb_LoadFile";
            this.Gb_LoadFile.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_LoadFile.Size = new System.Drawing.Size(764, 92);
            this.Gb_LoadFile.TabIndex = 15;
            this.Gb_LoadFile.TabStop = false;
            this.Gb_LoadFile.Text = "Upload File";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 51);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 19);
            this.button4.TabIndex = 1;
            this.button4.Text = "Select File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Txt_PathFile
            // 
            this.Txt_PathFile.Location = new System.Drawing.Point(36, 53);
            this.Txt_PathFile.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PathFile.Name = "Txt_PathFile";
            this.Txt_PathFile.Size = new System.Drawing.Size(166, 20);
            this.Txt_PathFile.TabIndex = 0;
            // 
            // Lnk_File_Created
            // 
            this.Lnk_File_Created.AutoSize = true;
            this.Lnk_File_Created.Location = new System.Drawing.Point(626, 232);
            this.Lnk_File_Created.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lnk_File_Created.Name = "Lnk_File_Created";
            this.Lnk_File_Created.Size = new System.Drawing.Size(55, 13);
            this.Lnk_File_Created.TabIndex = 16;
            this.Lnk_File_Created.TabStop = true;
            this.Lnk_File_Created.Text = "linkLabel1";
            this.Lnk_File_Created.Visible = false;
            this.Lnk_File_Created.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_File_Created_LinkClicked);
            // 
            // Lbl_Profiles_Created
            // 
            this.Lbl_Profiles_Created.AutoSize = true;
            this.Lbl_Profiles_Created.Location = new System.Drawing.Point(626, 211);
            this.Lbl_Profiles_Created.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Profiles_Created.Name = "Lbl_Profiles_Created";
            this.Lbl_Profiles_Created.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Profiles_Created.TabIndex = 17;
            this.Lbl_Profiles_Created.Text = "Generated profiles:";
            this.Lbl_Profiles_Created.Visible = false;
            // 
            // Gb_Configs
            // 
            this.Gb_Configs.Controls.Add(this.groupBox1);
            this.Gb_Configs.Controls.Add(this.Lbl_Profiles_Created);
            this.Gb_Configs.Controls.Add(this.label1);
            this.Gb_Configs.Controls.Add(this.Lnk_File_Created);
            this.Gb_Configs.Controls.Add(this.TxtRole);
            this.Gb_Configs.Controls.Add(this.button1);
            this.Gb_Configs.Controls.Add(this.label2);
            this.Gb_Configs.Controls.Add(this.BtnGenerate_Profiles);
            this.Gb_Configs.Controls.Add(this.dataGridView1);
            this.Gb_Configs.Controls.Add(this.dataGridView2);
            this.Gb_Configs.Controls.Add(this.TxtIndustry);
            this.Gb_Configs.Controls.Add(this.button3);
            this.Gb_Configs.Location = new System.Drawing.Point(28, 134);
            this.Gb_Configs.Name = "Gb_Configs";
            this.Gb_Configs.Size = new System.Drawing.Size(778, 283);
            this.Gb_Configs.TabIndex = 18;
            this.Gb_Configs.TabStop = false;
            this.Gb_Configs.Text = "Configs Creator";
            this.Gb_Configs.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 433);
            this.Controls.Add(this.Gb_Configs);
            this.Controls.Add(this.Gb_LoadFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Gb_LoadFile.ResumeLayout(false);
            this.Gb_LoadFile.PerformLayout();
            this.Gb_Configs.ResumeLayout(false);
            this.Gb_Configs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton Rb_en;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox TxtRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGenerate_Profiles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtIndustry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terms;
        private System.Windows.Forms.GroupBox Gb_LoadFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Txt_PathFile;
        private System.Windows.Forms.LinkLabel Lnk_File_Created;
        private System.Windows.Forms.Label Lbl_Profiles_Created;
        private System.Windows.Forms.GroupBox Gb_Configs;
    }
}

