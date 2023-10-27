namespace BT_QuanLySinhVien
{
    partial class fXemDiem
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
            txtTenSV = new TextBox();
            dataGridView1 = new DataGridView();
            TenMH = new DataGridViewTextBoxColumn();
            Diem = new DataGridViewTextBoxColumn();
            btnXem = new Button();
            txtMaSV = new TextBox();
            cbKhoa = new ComboBox();
            lblMaSV = new Label();
            lblTenSV = new Label();
            lblKhoa = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenSV);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnXem);
            panel1.Controls.Add(txtMaSV);
            panel1.Controls.Add(cbKhoa);
            panel1.Controls.Add(lblMaSV);
            panel1.Controls.Add(lblTenSV);
            panel1.Controls.Add(lblKhoa);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 488);
            panel1.TabIndex = 1;
            // 
            // txtTenSV
            // 
            txtTenSV.BorderStyle = BorderStyle.FixedSingle;
            txtTenSV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSV.Location = new Point(172, 76);
            txtTenSV.Margin = new Padding(3, 2, 3, 2);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(366, 27);
            txtTenSV.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TenMH, Diem });
            dataGridView1.Location = new Point(38, 189);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(659, 281);
            dataGridView1.TabIndex = 16;
            // 
            // TenMH
            // 
            TenMH.HeaderText = "Tên môn học";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            TenMH.Width = 500;
            // 
            // Diem
            // 
            Diem.HeaderText = "Điểm";
            Diem.MinimumWidth = 6;
            Diem.Name = "Diem";
            Diem.Width = 200;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.White;
            btnXem.FlatStyle = FlatStyle.Popup;
            btnXem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXem.Location = new Point(599, 119);
            btnXem.Margin = new Padding(3, 2, 3, 2);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(97, 28);
            btnXem.TabIndex = 15;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            // 
            // txtMaSV
            // 
            txtMaSV.BorderStyle = BorderStyle.FixedSingle;
            txtMaSV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSV.Location = new Point(172, 26);
            txtMaSV.Margin = new Padding(3, 2, 3, 2);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(148, 27);
            txtMaSV.TabIndex = 11;
            // 
            // cbKhoa
            // 
            cbKhoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(172, 123);
            cbKhoa.Margin = new Padding(3, 2, 3, 2);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(192, 27);
            cbKhoa.TabIndex = 9;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaSV.Location = new Point(54, 30);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(91, 20);
            lblMaSV.TabIndex = 14;
            lblMaSV.Text = "Mã sinh viên";
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenSV.Location = new Point(54, 80);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(93, 20);
            lblTenSV.TabIndex = 13;
            lblTenSV.Text = "Tên sinh viên";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblKhoa.Location = new Point(54, 129);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(43, 20);
            lblKhoa.TabIndex = 12;
            lblKhoa.Text = "Khoa";
            // 
            // fXemDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 490);
            Controls.Add(panel1);
            Name = "fXemDiem";
            Text = "Xem điểm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTenSV;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn Diem;
        private Button btnXem;
        private TextBox txtMaSV;
        private ComboBox cbKhoa;
        private Label lblMaSV;
        private Label lblTenSV;
        private Label lblKhoa;
    }
}