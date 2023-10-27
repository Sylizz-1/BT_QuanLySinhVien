namespace BT_QuanLySinhVien
{
    partial class fXemDSSV
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
            cbTenKhoa = new ComboBox();
            dataGridView1 = new DataGridView();
            MaSo = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            btnXem = new Button();
            cbMaKhoa = new ComboBox();
            lblTenKhoa = new Label();
            lblMaKhoa = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbTenKhoa);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnXem);
            panel1.Controls.Add(cbMaKhoa);
            panel1.Controls.Add(lblTenKhoa);
            panel1.Controls.Add(lblMaKhoa);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 432);
            panel1.TabIndex = 2;
            // 
            // cbTenKhoa
            // 
            cbTenKhoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbTenKhoa.FormattingEnabled = true;
            cbTenKhoa.Location = new Point(178, 78);
            cbTenKhoa.Margin = new Padding(3, 2, 3, 2);
            cbTenKhoa.Name = "cbTenKhoa";
            cbTenKhoa.Size = new Size(192, 27);
            cbTenKhoa.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai });
            dataGridView1.Location = new Point(32, 134);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(827, 282);
            dataGridView1.TabIndex = 16;
            // 
            // MaSo
            // 
            MaSo.HeaderText = "Mã số";
            MaSo.MinimumWidth = 6;
            MaSo.Name = "MaSo";
            MaSo.Width = 200;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 200;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 125;
            // 
            // DienThoai
            // 
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.Width = 125;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.White;
            btnXem.FlatStyle = FlatStyle.Popup;
            btnXem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXem.Location = new Point(444, 78);
            btnXem.Margin = new Padding(3, 2, 3, 2);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(97, 25);
            btnXem.TabIndex = 15;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(178, 24);
            cbMaKhoa.Margin = new Padding(3, 2, 3, 2);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(192, 27);
            cbMaKhoa.TabIndex = 9;
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKhoa.Location = new Point(32, 84);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(68, 20);
            lblTenKhoa.TabIndex = 14;
            lblTenKhoa.Text = "Tên khoa";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKhoa.Location = new Point(32, 30);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(66, 20);
            lblMaKhoa.TabIndex = 12;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // fXemDSSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 430);
            Controls.Add(panel1);
            Name = "fXemDSSV";
            Text = "Xem sinh viên theon khoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbTenKhoa;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private Button btnXem;
        private ComboBox cbMaKhoa;
        private Label lblTenKhoa;
        private Label lblMaKhoa;
    }
}