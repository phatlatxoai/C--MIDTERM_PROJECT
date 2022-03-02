namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Form2_MSSV = new System.Windows.Forms.TextBox();
            this.txt_Form2_Hovaten = new System.Windows.Forms.TextBox();
            this.txt_Form2_Email = new System.Windows.Forms.TextBox();
            this.rd_Form2_Nam = new System.Windows.Forms.RadioButton();
            this.rd_Form2_Nu = new System.Windows.Forms.RadioButton();
            this.bnt_Form2_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txt_Form2_MSSV
            // 
            this.txt_Form2_MSSV.Location = new System.Drawing.Point(195, 37);
            this.txt_Form2_MSSV.Name = "txt_Form2_MSSV";
            this.txt_Form2_MSSV.Size = new System.Drawing.Size(190, 22);
            this.txt_Form2_MSSV.TabIndex = 4;
            this.txt_Form2_MSSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Form2_Hovaten
            // 
            this.txt_Form2_Hovaten.Location = new System.Drawing.Point(195, 88);
            this.txt_Form2_Hovaten.Name = "txt_Form2_Hovaten";
            this.txt_Form2_Hovaten.Size = new System.Drawing.Size(307, 22);
            this.txt_Form2_Hovaten.TabIndex = 5;
            this.txt_Form2_Hovaten.TextChanged += new System.EventHandler(this.btn_Form2_Hovaten_TextChanged);
            // 
            // txt_Form2_Email
            // 
            this.txt_Form2_Email.Location = new System.Drawing.Point(195, 213);
            this.txt_Form2_Email.Name = "txt_Form2_Email";
            this.txt_Form2_Email.Size = new System.Drawing.Size(307, 22);
            this.txt_Form2_Email.TabIndex = 6;
            // 
            // rd_Form2_Nam
            // 
            this.rd_Form2_Nam.AutoSize = true;
            this.rd_Form2_Nam.Location = new System.Drawing.Point(195, 153);
            this.rd_Form2_Nam.Name = "rd_Form2_Nam";
            this.rd_Form2_Nam.Size = new System.Drawing.Size(57, 20);
            this.rd_Form2_Nam.TabIndex = 7;
            this.rd_Form2_Nam.TabStop = true;
            this.rd_Form2_Nam.Text = "Nam";
            this.rd_Form2_Nam.UseVisualStyleBackColor = true;
            // 
            // rd_Form2_Nu
            // 
            this.rd_Form2_Nu.AutoSize = true;
            this.rd_Form2_Nu.Location = new System.Drawing.Point(330, 155);
            this.rd_Form2_Nu.Name = "rd_Form2_Nu";
            this.rd_Form2_Nu.Size = new System.Drawing.Size(45, 20);
            this.rd_Form2_Nu.TabIndex = 8;
            this.rd_Form2_Nu.TabStop = true;
            this.rd_Form2_Nu.Text = "Nữ";
            this.rd_Form2_Nu.UseVisualStyleBackColor = true;
            // 
            // bnt_Form2_Luu
            // 
            this.bnt_Form2_Luu.Location = new System.Drawing.Point(195, 296);
            this.bnt_Form2_Luu.Name = "bnt_Form2_Luu";
            this.bnt_Form2_Luu.Size = new System.Drawing.Size(214, 42);
            this.bnt_Form2_Luu.TabIndex = 9;
            this.bnt_Form2_Luu.Text = "Lưu dữ liệu";
            this.bnt_Form2_Luu.UseVisualStyleBackColor = true;
            this.bnt_Form2_Luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.bnt_Form2_Luu);
            this.Controls.Add(this.rd_Form2_Nu);
            this.Controls.Add(this.rd_Form2_Nam);
            this.Controls.Add(this.txt_Form2_Email);
            this.Controls.Add(this.txt_Form2_Hovaten);
            this.Controls.Add(this.txt_Form2_MSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Form2_MSSV;
        private System.Windows.Forms.TextBox txt_Form2_Hovaten;
        private System.Windows.Forms.TextBox txt_Form2_Email;
        private System.Windows.Forms.RadioButton rd_Form2_Nam;
        private System.Windows.Forms.RadioButton rd_Form2_Nu;
        private System.Windows.Forms.Button bnt_Form2_Luu;
    }
}