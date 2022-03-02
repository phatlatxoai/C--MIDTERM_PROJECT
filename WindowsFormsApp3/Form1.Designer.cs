namespace WindowsFormsApp3
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
            this.dtg_Sinhvien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_FORM1_chu = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_form1_Napdulieu = new System.Windows.Forms.Button();
            this.btn_Form_Xoadulieu = new System.Windows.Forms.Button();
            this.btn_Form1_Suathongtin = new System.Windows.Forms.Button();
            this.btn_Form1_Themmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Sinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Sinhvien
            // 
            this.dtg_Sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Sinhvien.Location = new System.Drawing.Point(12, 29);
            this.dtg_Sinhvien.Name = "dtg_Sinhvien";
            this.dtg_Sinhvien.RowHeadersWidth = 51;
            this.dtg_Sinhvien.RowTemplate.Height = 24;
            this.dtg_Sinhvien.Size = new System.Drawing.Size(776, 322);
            this.dtg_Sinhvien.TabIndex = 0;
            this.dtg_Sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Sinhvien_CellClick);
            this.dtg_Sinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Sinhvien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_FORM1_chu);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_form1_Napdulieu);
            this.groupBox1.Controls.Add(this.btn_Form_Xoadulieu);
            this.groupBox1.Controls.Add(this.btn_Form1_Suathongtin);
            this.groupBox1.Controls.Add(this.btn_Form1_Themmoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác trên dữ liệu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_FORM1_chu
            // 
            this.lb_FORM1_chu.AutoSize = true;
            this.lb_FORM1_chu.Location = new System.Drawing.Point(251, 71);
            this.lb_FORM1_chu.Name = "lb_FORM1_chu";
            this.lb_FORM1_chu.Size = new System.Drawing.Size(44, 16);
            this.lb_FORM1_chu.TabIndex = 5;
            this.lb_FORM1_chu.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(494, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_form1_Napdulieu
            // 
            this.btn_form1_Napdulieu.Location = new System.Drawing.Point(413, 41);
            this.btn_form1_Napdulieu.Name = "btn_form1_Napdulieu";
            this.btn_form1_Napdulieu.Size = new System.Drawing.Size(75, 23);
            this.btn_form1_Napdulieu.TabIndex = 3;
            this.btn_form1_Napdulieu.Text = "Nạp dữ liệu từ excel";
            this.btn_form1_Napdulieu.UseVisualStyleBackColor = true;
            // 
            // btn_Form_Xoadulieu
            // 
            this.btn_Form_Xoadulieu.Location = new System.Drawing.Point(332, 41);
            this.btn_Form_Xoadulieu.Name = "btn_Form_Xoadulieu";
            this.btn_Form_Xoadulieu.Size = new System.Drawing.Size(75, 23);
            this.btn_Form_Xoadulieu.TabIndex = 2;
            this.btn_Form_Xoadulieu.Text = "Xóa dữ liệu";
            this.btn_Form_Xoadulieu.UseVisualStyleBackColor = true;
            this.btn_Form_Xoadulieu.Click += new System.EventHandler(this.btn_Form_Xoadulieu_Click);
            // 
            // btn_Form1_Suathongtin
            // 
            this.btn_Form1_Suathongtin.Location = new System.Drawing.Point(251, 41);
            this.btn_Form1_Suathongtin.Name = "btn_Form1_Suathongtin";
            this.btn_Form1_Suathongtin.Size = new System.Drawing.Size(75, 23);
            this.btn_Form1_Suathongtin.TabIndex = 1;
            this.btn_Form1_Suathongtin.Text = "Sửa thông tin";
            this.btn_Form1_Suathongtin.UseVisualStyleBackColor = true;
            this.btn_Form1_Suathongtin.Click += new System.EventHandler(this.btn_Form1_Suathongtin_Click);
            // 
            // btn_Form1_Themmoi
            // 
            this.btn_Form1_Themmoi.Location = new System.Drawing.Point(170, 41);
            this.btn_Form1_Themmoi.Name = "btn_Form1_Themmoi";
            this.btn_Form1_Themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_Form1_Themmoi.TabIndex = 0;
            this.btn_Form1_Themmoi.Text = "Thêm mới ";
            this.btn_Form1_Themmoi.UseVisualStyleBackColor = true;
            this.btn_Form1_Themmoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_Sinhvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Sinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Sinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_form1_Napdulieu;
        private System.Windows.Forms.Button btn_Form_Xoadulieu;
        private System.Windows.Forms.Button btn_Form1_Suathongtin;
        private System.Windows.Forms.Button btn_Form1_Themmoi;
        private System.Windows.Forms.Label lb_FORM1_chu;
    }
}

