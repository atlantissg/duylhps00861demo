namespace test1
{
    partial class updatecategory
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonAdddm = new System.Windows.Forms.Button();
            this.labelMadm = new System.Windows.Forms.Label();
            this.textBoxtenDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(173, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Hoạt động";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(224, 145);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 15;
            this.buttonHuy.Text = "Thoát";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonAdddm
            // 
            this.buttonAdddm.Location = new System.Drawing.Point(105, 145);
            this.buttonAdddm.Name = "buttonAdddm";
            this.buttonAdddm.Size = new System.Drawing.Size(75, 23);
            this.buttonAdddm.TabIndex = 14;
            this.buttonAdddm.Text = "Update";
            this.buttonAdddm.UseVisualStyleBackColor = true;
            this.buttonAdddm.Click += new System.EventHandler(this.buttonAdddm_Click);
            // 
            // labelMadm
            // 
            this.labelMadm.AutoSize = true;
            this.labelMadm.Location = new System.Drawing.Point(184, 23);
            this.labelMadm.Name = "labelMadm";
            this.labelMadm.Size = new System.Drawing.Size(0, 13);
            this.labelMadm.TabIndex = 13;
            this.labelMadm.Click += new System.EventHandler(this.labelMadm_Click);
            // 
            // textBoxtenDM
            // 
            this.textBoxtenDM.Location = new System.Drawing.Point(173, 51);
            this.textBoxtenDM.Name = "textBoxtenDM";
            this.textBoxtenDM.Size = new System.Drawing.Size(126, 20);
            this.textBoxtenDM.TabIndex = 12;
            this.textBoxtenDM.TextChanged += new System.EventHandler(this.textBoxtenDM_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã danh mục";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên danh mục";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trạng thái";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // updatecategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 193);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonAdddm);
            this.Controls.Add(this.labelMadm);
            this.Controls.Add(this.textBoxtenDM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "updatecategory";
            this.Text = "updatecategory";
            this.Load += new System.EventHandler(this.updatecategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonAdddm;
        private System.Windows.Forms.Label labelMadm;
        private System.Windows.Forms.TextBox textBoxtenDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}