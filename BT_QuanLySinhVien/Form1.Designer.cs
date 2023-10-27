namespace BT_QuanLySinhVien
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage_SinhVien = new TabPage();
            tabPage_Khoa = new TabPage();
            tabPage_MonHoc = new TabPage();
            tabPage_NhapDiem = new TabPage();
            tabPage_XemDiem = new TabPage();
            tabPage_ThongKe = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 693);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Hệ thống";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(72, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Chức năng";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(143, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Hỗ trợ";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_SinhVien);
            tabControl1.Controls.Add(tabPage_Khoa);
            tabControl1.Controls.Add(tabPage_MonHoc);
            tabControl1.Controls.Add(tabPage_NhapDiem);
            tabControl1.Controls.Add(tabPage_XemDiem);
            tabControl1.Controls.Add(tabPage_ThongKe);
            tabControl1.Location = new Point(2, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1198, 670);
            tabControl1.TabIndex = 3;
            // 
            // tabPage_SinhVien
            // 
            tabPage_SinhVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_SinhVien.Location = new Point(4, 24);
            tabPage_SinhVien.Name = "tabPage_SinhVien";
            tabPage_SinhVien.Padding = new Padding(3);
            tabPage_SinhVien.Size = new Size(1190, 642);
            tabPage_SinhVien.TabIndex = 0;
            tabPage_SinhVien.Text = "Sinh Viên";
            tabPage_SinhVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_Khoa
            // 
            tabPage_Khoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_Khoa.Location = new Point(4, 24);
            tabPage_Khoa.Name = "tabPage_Khoa";
            tabPage_Khoa.Padding = new Padding(3);
            tabPage_Khoa.RightToLeft = RightToLeft.No;
            tabPage_Khoa.Size = new Size(1190, 642);
            tabPage_Khoa.TabIndex = 1;
            tabPage_Khoa.Text = "Khoa";
            tabPage_Khoa.UseVisualStyleBackColor = true;
            // 
            // tabPage_MonHoc
            // 
            tabPage_MonHoc.AutoScroll = true;
            tabPage_MonHoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_MonHoc.Location = new Point(4, 24);
            tabPage_MonHoc.Name = "tabPage_MonHoc";
            tabPage_MonHoc.Padding = new Padding(3);
            tabPage_MonHoc.Size = new Size(1190, 642);
            tabPage_MonHoc.TabIndex = 2;
            tabPage_MonHoc.Text = "Môn Học";
            tabPage_MonHoc.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhapDiem
            // 
            tabPage_NhapDiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_NhapDiem.Location = new Point(4, 24);
            tabPage_NhapDiem.Name = "tabPage_NhapDiem";
            tabPage_NhapDiem.Padding = new Padding(3);
            tabPage_NhapDiem.Size = new Size(1190, 642);
            tabPage_NhapDiem.TabIndex = 3;
            tabPage_NhapDiem.Text = "Nhập Điểm";
            tabPage_NhapDiem.UseVisualStyleBackColor = true;
            // 
            // tabPage_XemDiem
            // 
            tabPage_XemDiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_XemDiem.Location = new Point(4, 24);
            tabPage_XemDiem.Name = "tabPage_XemDiem";
            tabPage_XemDiem.Padding = new Padding(3);
            tabPage_XemDiem.Size = new Size(1190, 642);
            tabPage_XemDiem.TabIndex = 4;
            tabPage_XemDiem.Text = "Xem Điểm";
            tabPage_XemDiem.UseVisualStyleBackColor = true;
            // 
            // tabPage_ThongKe
            // 
            tabPage_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage_ThongKe.Location = new Point(4, 24);
            tabPage_ThongKe.Name = "tabPage_ThongKe";
            tabPage_ThongKe.Padding = new Padding(3);
            tabPage_ThongKe.Size = new Size(1190, 642);
            tabPage_ThongKe.TabIndex = 5;
            tabPage_ThongKe.Text = "Thống Kê Khoa";
            tabPage_ThongKe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 693);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage_SinhVien;
        private TabPage tabPage_Khoa;
        private TabPage tabPage_MonHoc;
        private TabPage tabPage_NhapDiem;
        private TabPage tabPage_XemDiem;
        private TabPage tabPage_ThongKe;
    }
}