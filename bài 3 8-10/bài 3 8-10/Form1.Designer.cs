namespace bài_3_8_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupLeft;
        private System.Windows.Forms.GroupBox groupRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboDonVi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnMa;
        private System.Windows.Forms.ColumnHeader columnTen;
        private System.Windows.Forms.ColumnHeader columnDonVi;
        private System.Windows.Forms.ColumnHeader columnDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaToanBo;

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
            components = new System.ComponentModel.Container();
            this.groupLeft = new System.Windows.Forms.GroupBox();
            this.groupRight = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboDonVi = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnMa = new System.Windows.Forms.ColumnHeader();
            this.columnTen = new System.Windows.Forms.ColumnHeader();
            this.columnDonVi = new System.Windows.Forms.ColumnHeader();
            this.columnDonGia = new System.Windows.Forms.ColumnHeader();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            // 
            // groupLeft
            // 
            this.groupLeft.SuspendLayout();
            this.groupLeft.Text = "Nhập liệu";
            this.groupLeft.Location = new System.Drawing.Point(12, 12);
            this.groupLeft.Size = new System.Drawing.Size(320, 426);
            // 
            // groupRight
            // 
            this.groupRight.SuspendLayout();
            this.groupRight.Text = "Danh sách";
            this.groupRight.Location = new System.Drawing.Point(338, 12);
            this.groupRight.Size = new System.Drawing.Size(450, 426);
            // 
            // labels and inputs
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Text = "Mã vật tư";
            this.txtMa.Location = new System.Drawing.Point(16, 48);
            this.txtMa.Width = 280;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Text = "Tên vật tư";
            this.txtTen.Location = new System.Drawing.Point(16, 108);
            this.txtTen.Width = 280;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Text = "Đơn vị tính";
            this.cboDonVi.Location = new System.Drawing.Point(16, 168);
            this.cboDonVi.Width = 150;
            this.cboDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonVi.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Text = "Đơn giá nhập";
            this.txtDonGia.Location = new System.Drawing.Point(16, 228);
            this.txtDonGia.Width = 150;

            // buttons
            this.btnThem.Location = new System.Drawing.Point(16, 272);
            this.btnThem.Size = new System.Drawing.Size(120, 32);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);

            this.btnCapNhat.Location = new System.Drawing.Point(176, 272);
            this.btnCapNhat.Size = new System.Drawing.Size(120, 32);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);

            this.btnXoaDong.Location = new System.Drawing.Point(16, 320);
            this.btnXoaDong.Size = new System.Drawing.Size(120, 32);
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.Click += new System.EventHandler(this.BtnXoaDong_Click);

            this.btnXoaToanBo.Location = new System.Drawing.Point(176, 320);
            this.btnXoaToanBo.Size = new System.Drawing.Size(120, 32);
            this.btnXoaToanBo.Text = "Xóa toàn bộ";
            this.btnXoaToanBo.Click += new System.EventHandler(this.BtnXoaToanBo_Click);

            // listView
            this.listViewItems.Location = new System.Drawing.Point(12, 24);
            this.listViewItems.Size = new System.Drawing.Size(426, 392);
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.columnMa,
                this.columnTen,
                this.columnDonVi,
                this.columnDonGia
            });
            this.columnMa.Text = "Mã VT";
            this.columnMa.Width = 80;
            this.columnTen.Text = "Tên VT";
            this.columnTen.Width = 160;
            this.columnDonVi.Text = "Đơn vị";
            this.columnDonVi.Width = 80;
            this.columnDonGia.Text = "Đơn giá";
            this.columnDonGia.Width = 100;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.ListViewItems_SelectedIndexChanged);

            // assemble controls
            this.groupLeft.Controls.Add(this.label1);
            this.groupLeft.Controls.Add(this.txtMa);
            this.groupLeft.Controls.Add(this.label2);
            this.groupLeft.Controls.Add(this.txtTen);
            this.groupLeft.Controls.Add(this.label3);
            this.groupLeft.Controls.Add(this.cboDonVi);
            this.groupLeft.Controls.Add(this.label4);
            this.groupLeft.Controls.Add(this.txtDonGia);
            this.groupLeft.Controls.Add(this.btnThem);
            this.groupLeft.Controls.Add(this.btnCapNhat);
            this.groupLeft.Controls.Add(this.btnXoaDong);
            this.groupLeft.Controls.Add(this.btnXoaToanBo);

            this.groupRight.Controls.Add(this.listViewItems);

            this.Controls.Add(this.groupLeft);
            this.Controls.Add(this.groupRight);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Quản lý danh mục Vật tư / Linh kiện";

            this.groupLeft.ResumeLayout(false);
            this.groupLeft.PerformLayout();
            this.groupRight.ResumeLayout(false);
        }

        #endregion
    }
}
