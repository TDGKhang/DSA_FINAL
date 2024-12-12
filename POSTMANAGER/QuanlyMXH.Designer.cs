namespace POSTMANAGER
{
    partial class QuanlyMXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanlyMXH));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDungBaiDang = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvbaiDang = new System.Windows.Forms.DataGridView();
            this.PostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungBaiDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPostID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpngayDang = new System.Windows.Forms.DateTimePicker();
            this.btnSuaBaiDang = new System.Windows.Forms.Button();
            this.btnXoaBaiDang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaiDang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung bài đăng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tác giả";
            // 
            // txtNoiDungBaiDang
            // 
            this.txtNoiDungBaiDang.Location = new System.Drawing.Point(96, 298);
            this.txtNoiDungBaiDang.Multiline = true;
            this.txtNoiDungBaiDang.Name = "txtNoiDungBaiDang";
            this.txtNoiDungBaiDang.Size = new System.Drawing.Size(316, 35);
            this.txtNoiDungBaiDang.TabIndex = 2;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(96, 198);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(316, 36);
            this.txtTacGia.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::POSTMANAGER.Properties.Resources.plus;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(141, 466);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(226, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm Bài Đăng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::POSTMANAGER.Properties.Resources.logout__2_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1401, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 60);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Đăng Xuất";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvbaiDang);
            this.groupBox1.Location = new System.Drawing.Point(507, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 650);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bài Đăng";
            // 
            // dgvbaiDang
            // 
            this.dgvbaiDang.BackgroundColor = System.Drawing.Color.White;
            this.dgvbaiDang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvbaiDang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaiDang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostID,
            this.noiDungBaiDang,
            this.tacGia,
            this.ngayDang});
            this.dgvbaiDang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbaiDang.Location = new System.Drawing.Point(3, 18);
            this.dgvbaiDang.Name = "dgvbaiDang";
            this.dgvbaiDang.RowHeadersWidth = 51;
            this.dgvbaiDang.RowTemplate.Height = 24;
            this.dgvbaiDang.Size = new System.Drawing.Size(938, 629);
            this.dgvbaiDang.TabIndex = 0;
            this.dgvbaiDang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbaiDang_CellClick);
            // 
            // PostID
            // 
            this.PostID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PostID.DataPropertyName = "PostID";
            this.PostID.HeaderText = "PostID";
            this.PostID.MinimumWidth = 6;
            this.PostID.Name = "PostID";
            // 
            // noiDungBaiDang
            // 
            this.noiDungBaiDang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDungBaiDang.DataPropertyName = "noiDungBaiDang";
            this.noiDungBaiDang.HeaderText = "Nội Dung Bài Đăng";
            this.noiDungBaiDang.MinimumWidth = 6;
            this.noiDungBaiDang.Name = "noiDungBaiDang";
            // 
            // tacGia
            // 
            this.tacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác Giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            // 
            // ngayDang
            // 
            this.ngayDang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayDang.DataPropertyName = "ngayDang";
            this.ngayDang.HeaderText = "Ngày Đăng";
            this.ngayDang.MinimumWidth = 6;
            this.ngayDang.Name = "ngayDang";
            // 
            // txtPostID
            // 
            this.txtPostID.Location = new System.Drawing.Point(96, 98);
            this.txtPostID.Multiline = true;
            this.txtPostID.Name = "txtPostID";
            this.txtPostID.Size = new System.Drawing.Size(316, 35);
            this.txtPostID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PostID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày Đăng";
            // 
            // dtpngayDang
            // 
            this.dtpngayDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpngayDang.Location = new System.Drawing.Point(96, 398);
            this.dtpngayDang.Name = "dtpngayDang";
            this.dtpngayDang.Size = new System.Drawing.Size(316, 27);
            this.dtpngayDang.TabIndex = 10;
            // 
            // btnSuaBaiDang
            // 
            this.btnSuaBaiDang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaBaiDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaBaiDang.Image = global::POSTMANAGER.Properties.Resources.edit;
            this.btnSuaBaiDang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBaiDang.Location = new System.Drawing.Point(141, 546);
            this.btnSuaBaiDang.Name = "btnSuaBaiDang";
            this.btnSuaBaiDang.Size = new System.Drawing.Size(226, 55);
            this.btnSuaBaiDang.TabIndex = 11;
            this.btnSuaBaiDang.Text = "Sửa Bài Đăng";
            this.btnSuaBaiDang.UseVisualStyleBackColor = true;
            this.btnSuaBaiDang.Click += new System.EventHandler(this.btnSuaBaiDang_Click);
            // 
            // btnXoaBaiDang
            // 
            this.btnXoaBaiDang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaBaiDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaBaiDang.Image = global::POSTMANAGER.Properties.Resources.trash;
            this.btnXoaBaiDang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBaiDang.Location = new System.Drawing.Point(141, 626);
            this.btnXoaBaiDang.Name = "btnXoaBaiDang";
            this.btnXoaBaiDang.Size = new System.Drawing.Size(226, 55);
            this.btnXoaBaiDang.TabIndex = 12;
            this.btnXoaBaiDang.Text = "Xóa Bài Đăng";
            this.btnXoaBaiDang.UseVisualStyleBackColor = true;
            this.btnXoaBaiDang.Click += new System.EventHandler(this.btnXoaBaiDang_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::POSTMANAGER.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(220, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::POSTMANAGER.Properties.Resources.dai_mau_xam;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(420, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Quản lý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::POSTMANAGER.Properties.Resources.ctgr;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNoiDungBaiDang);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSuaBaiDang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnXoaBaiDang);
            this.panel1.Controls.Add(this.txtPostID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpngayDang);
            this.panel1.Controls.Add(this.txtTacGia);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(45, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 776);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::POSTMANAGER.Properties.Resources.name;
            this.pictureBox5.Location = new System.Drawing.Point(1217, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POSTMANAGER.Properties.Resources._432549275_1954857968241471_1983953852552473237_n;
            this.pictureBox2.Location = new System.Drawing.Point(1324, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(39, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản lý";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1580, 100);
            this.panel3.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(920, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 44);
            this.button4.TabIndex = 19;
            this.button4.Text = "Phân tích";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(670, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "Thống kê";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::POSTMANAGER.Properties.Resources.lgo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 70);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // QuanlyMXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POSTMANAGER.Properties.Resources.image_4822__HasThumb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 933);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "QuanlyMXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POST MANAGER";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaiDang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiDungBaiDang;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvbaiDang;
        private System.Windows.Forms.TextBox txtPostID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpngayDang;
        private System.Windows.Forms.Button btnSuaBaiDang;
        private System.Windows.Forms.Button btnXoaBaiDang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungBaiDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDang;
    }
}