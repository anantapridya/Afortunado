
namespace TenantMonet
{
    partial class Menu
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
            this.btnInputKendaraan = new System.Windows.Forms.Button();
            this.btnSewa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btnInputKendaraan
            // 
            this.btnInputKendaraan.AutoSize = true;
            this.btnInputKendaraan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputKendaraan.Location = new System.Drawing.Point(12, 75);
            this.btnInputKendaraan.Name = "btnInputKendaraan";
            this.btnInputKendaraan.Size = new System.Drawing.Size(140, 30);
            this.btnInputKendaraan.TabIndex = 1;
            this.btnInputKendaraan.Text = "Input Kendaraan";
            this.btnInputKendaraan.UseVisualStyleBackColor = true;
            this.btnInputKendaraan.Click += new System.EventHandler(this.btnInputKendaraan_Click);
            // 
            // btnSewa
            // 
            this.btnSewa.AutoSize = true;
            this.btnSewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSewa.Location = new System.Drawing.Point(12, 129);
            this.btnSewa.Name = "btnSewa";
            this.btnSewa.Size = new System.Drawing.Size(140, 30);
            this.btnSewa.TabIndex = 1;
            this.btnSewa.Text = "Sewa";
            this.btnSewa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Daftar Kendaraan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSewa);
            this.Controls.Add(this.btnInputKendaraan);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInputKendaraan;
        private System.Windows.Forms.Button btnSewa;
        private System.Windows.Forms.Button button1;
    }
}