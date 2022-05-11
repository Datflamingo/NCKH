
namespace NCKH_QLHH
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
            this.btn_quanli = new System.Windows.Forms.Button();
            this.btn_chinhsua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quanli
            // 
            this.btn_quanli.Location = new System.Drawing.Point(238, 98);
            this.btn_quanli.Name = "btn_quanli";
            this.btn_quanli.Size = new System.Drawing.Size(259, 98);
            this.btn_quanli.TabIndex = 0;
            this.btn_quanli.Text = "Quan Li";
            this.btn_quanli.UseVisualStyleBackColor = true;
            this.btn_quanli.Click += new System.EventHandler(this.btn_quanli_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Location = new System.Drawing.Point(238, 227);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(259, 98);
            this.btn_chinhsua.TabIndex = 1;
            this.btn_chinhsua.Text = "Chinh sua";
            this.btn_chinhsua.UseVisualStyleBackColor = true;
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chinhsua);
            this.Controls.Add(this.btn_quanli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quanli;
        private System.Windows.Forms.Button btn_chinhsua;
    }
}

