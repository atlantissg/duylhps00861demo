namespace test1
{
    partial class addcategory
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
            this.textBoxtenDM = new System.Windows.Forms.TextBox();
            this.labelMadm = new System.Windows.Forms.Label();
            this.buttonAdddm = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên danh mục";
            // 
            // textBoxtenDM
            // 
            this.textBoxtenDM.Location = new System.Drawing.Point(168, 26);
            this.textBoxtenDM.Name = "textBoxtenDM";
            this.textBoxtenDM.Size = new System.Drawing.Size(154, 20);
            this.textBoxtenDM.TabIndex = 3;
            // 
            // labelMadm
            // 
            this.labelMadm.AutoSize = true;
            this.labelMadm.Location = new System.Drawing.Point(176, 26);
            this.labelMadm.Name = "labelMadm";
            this.labelMadm.Size = new System.Drawing.Size(0, 13);
            this.labelMadm.TabIndex = 5;
            // 
            // buttonAdddm
            // 
            this.buttonAdddm.Location = new System.Drawing.Point(100, 120);
            this.buttonAdddm.Name = "buttonAdddm";
            this.buttonAdddm.Size = new System.Drawing.Size(75, 23);
            this.buttonAdddm.TabIndex = 6;
            this.buttonAdddm.Text = "Thêm";
            this.buttonAdddm.UseVisualStyleBackColor = true;
            this.buttonAdddm.Click += new System.EventHandler(this.buttonAdddm_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(219, 120);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 7;
            this.buttonHuy.Text = "Thoát";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(168, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Hoạt động";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 168);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonAdddm);
            this.Controls.Add(this.labelMadm);
            this.Controls.Add(this.textBoxtenDM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addcategory";
            this.Text = "Danh muc";
            this.Load += new System.EventHandler(this.addcategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxtenDM;
        private System.Windows.Forms.Label labelMadm;
        private System.Windows.Forms.Button buttonAdddm;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}