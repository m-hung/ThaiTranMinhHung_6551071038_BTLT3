namespace baitapHoTen
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
            lblHoTen = new Label();
            lblHoLot = new Label();
            lblTen = new Label();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnExit = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.BackColor = Color.Cyan;
            lblHoTen.Font = new Font("Segoe UI", 20F);
            lblHoTen.Location = new Point(82, 27);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(0, 46);
            lblHoTen.TabIndex = 0;
            lblHoTen.DoubleClick += label1_Click;
            // 
            // lblHoLot
            // 
            lblHoLot.AutoSize = true;
            lblHoLot.Location = new Point(59, 99);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(51, 20);
            lblHoLot.TabIndex = 1;
            lblHoLot.Text = "Họ lót";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(60, 166);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên";
            // 
            // btnHo
            // 
            btnHo.Location = new Point(82, 304);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 29);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(341, 304);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 4;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(606, 304);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(290, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(207, 37);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát Chương trình";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(183, 99);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(314, 27);
            txtHo.TabIndex = 7;
            txtHo.DoubleClick += label1_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(183, 166);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(314, 27);
            txtTen.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnExit);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(lblTen);
            Controls.Add(lblHoLot);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Bài tập Họ Tên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblHoLot;
        private Label lblTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnExit;
        private TextBox txtHo;
        private TextBox txtTen;
    }
}
