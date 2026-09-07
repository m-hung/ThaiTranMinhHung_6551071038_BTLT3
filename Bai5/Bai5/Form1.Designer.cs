namespace Bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkGachChan = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            txtNhapTen = new TextBox();
            label2 = new Label();
            lblLapTrinh = new TextBox();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(55, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Tên:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(51, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(22, 186);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(22, 136);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(22, 84);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(22, 40);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 128);
            groupBox2.Controls.Add(chkGachChan);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(413, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 232);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkGachChan
            // 
            chkGachChan.AutoSize = true;
            chkGachChan.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            chkGachChan.Location = new Point(34, 186);
            chkGachChan.Name = "chkGachChan";
            chkGachChan.Size = new Size(101, 24);
            chkGachChan.TabIndex = 2;
            chkGachChan.Text = "Gạch Chân";
            chkGachChan.UseVisualStyleBackColor = true;
            chkGachChan.CheckedChanged += chkGachChan_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            chkItalic.Location = new Point(34, 111);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(121, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.Location = new Point(34, 41);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(161, 27);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(335, 27);
            txtNhapTen.TabIndex = 3;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 345);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Lập Trình bởi";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.Location = new Point(176, 342);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(188, 27);
            lblLapTrinh.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(497, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(txtNhapTen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Định dạng (Formater)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private TextBox txtNhapTen;
        private Label label2;
        private TextBox lblLapTrinh;
        private CheckBox chkGachChan;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Button btnExit;
    }
}
