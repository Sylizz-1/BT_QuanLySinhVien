namespace BT_QuanLySinhVien
{
    partial class fNhapDiem
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
            panel1 = new Panel();
            btnNhap = new Button();
            txtDiem = new TextBox();
            txtHoTen = new ComboBox();
            txtMaMon = new ComboBox();
            txtTenMon = new ComboBox();
            txtMaSo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNhap);
            panel1.Controls.Add(txtDiem);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtMaMon);
            panel1.Controls.Add(txtTenMon);
            panel1.Controls.Add(txtMaSo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 406);
            panel1.TabIndex = 1;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.White;
            btnNhap.FlatStyle = FlatStyle.Popup;
            btnNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhap.Location = new Point(362, 362);
            btnNhap.Margin = new Padding(3, 2, 3, 2);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(97, 28);
            btnNhap.TabIndex = 6;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // txtDiem
            // 
            txtDiem.BorderStyle = BorderStyle.FixedSingle;
            txtDiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiem.Location = new Point(186, 280);
            txtDiem.Margin = new Padding(3, 2, 3, 2);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(148, 27);
            txtDiem.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.FormattingEnabled = true;
            txtHoTen.Location = new Point(186, 132);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(286, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaMon.FormattingEnabled = true;
            txtMaMon.Location = new Point(186, 181);
            txtMaMon.Margin = new Padding(3, 2, 3, 2);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(192, 27);
            txtMaMon.TabIndex = 3;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenMon.FormattingEnabled = true;
            txtTenMon.Location = new Point(186, 231);
            txtTenMon.Margin = new Padding(3, 2, 3, 2);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(286, 27);
            txtTenMon.TabIndex = 4;
            // 
            // txtMaSo
            // 
            txtMaSo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSo.FormattingEnabled = true;
            txtMaSo.Location = new Point(186, 83);
            txtMaSo.Margin = new Padding(3, 2, 3, 2);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(192, 27);
            txtMaSo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(86, 134);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 183);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "Mã môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(86, 233);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 282);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Điểm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 86);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã số";
            // 
            // fNhapDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 404);
            Controls.Add(panel1);
            Name = "fNhapDiem";
            Text = "Nhập điểm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNhap;
        private TextBox txtDiem;
        private ComboBox txtHoTen;
        private ComboBox txtMaMon;
        private ComboBox txtTenMon;
        private ComboBox txtMaSo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}