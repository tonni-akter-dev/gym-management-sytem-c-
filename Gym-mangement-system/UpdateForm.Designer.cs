namespace Gym_mangement_system
{
    partial class UpdateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TimingCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MemberSDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(34, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 54);
            this.button2.TabIndex = 37;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(215, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 54);
            this.button1.TabIndex = 36;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(601, 672);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 54);
            this.button3.TabIndex = 38;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TimingCb
            // 
            this.TimingCb.FormattingEnabled = true;
            this.TimingCb.Items.AddRange(new object[] {
            "6 AM - 8 AM",
            "8 AM - 10 AM",
            "6 PM - 8 PM",
            "8 PM - 10 PM"});
            this.TimingCb.Location = new System.Drawing.Point(34, 614);
            this.TimingCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimingCb.Name = "TimingCb";
            this.TimingCb.Size = new System.Drawing.Size(226, 28);
            this.TimingCb.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(36, 580);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Timing";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(36, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = " Monthly Amount";
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(40, 511);
            this.AmountTb.Multiline = true;
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(232, 44);
            this.AmountTb.TabIndex = 32;
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.GenderCb.Location = new System.Drawing.Point(40, 309);
            this.GenderCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(232, 28);
            this.GenderCb.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(42, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(42, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Age";
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(40, 400);
            this.AgeTb.Multiline = true;
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(232, 44);
            this.AgeTb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(42, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone Number";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(40, 186);
            this.PhoneTb.Multiline = true;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(232, 44);
            this.PhoneTb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(36, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Member Name";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(40, 78);
            this.NameTb.Multiline = true;
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(232, 44);
            this.NameTb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(534, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "UPDATE AND DELETE MEMBER";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(576, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 52);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fitness Center";
            // 
            // MemberSDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberSDGV.BackgroundColor = System.Drawing.Color.White;
            this.MemberSDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemberSDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MemberSDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MemberSDGV.EnableHeadersVisualStyles = false;
            this.MemberSDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberSDGV.Location = new System.Drawing.Point(294, 129);
            this.MemberSDGV.Name = "MemberSDGV";
            this.MemberSDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MemberSDGV.RowHeadersVisible = false;
            this.MemberSDGV.RowHeadersWidth = 62;
            this.MemberSDGV.RowTemplate.Height = 25;
            this.MemberSDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberSDGV.Size = new System.Drawing.Size(851, 495);
            this.MemberSDGV.TabIndex = 44;
            this.MemberSDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberSDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MemberSDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MemberSDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MemberSDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MemberSDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.MemberSDGV.ThemeStyle.ReadOnly = false;
            this.MemberSDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberSDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MemberSDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MemberSDGV.ThemeStyle.RowsStyle.Height = 25;
            this.MemberSDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.MemberSDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.MintCream;
            this.MemberSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberSDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1130, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(409, 672);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 54);
            this.button4.TabIndex = 46;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1203, 761);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberSDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TimingCb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox TimingCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView MemberSDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}