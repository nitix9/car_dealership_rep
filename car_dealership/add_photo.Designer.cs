
namespace car_dealership
{
    partial class add_photo
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
            this.waytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idcartxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.photolbl = new System.Windows.Forms.Label();
            this.add_pht = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // waytxt
            // 
            this.waytxt.Location = new System.Drawing.Point(120, 184);
            this.waytxt.Name = "waytxt";
            this.waytxt.Size = new System.Drawing.Size(110, 20);
            this.waytxt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Путь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Код машины:";
            // 
            // idcartxt
            // 
            this.idcartxt.Location = new System.Drawing.Point(120, 218);
            this.idcartxt.Name = "idcartxt";
            this.idcartxt.Size = new System.Drawing.Size(110, 20);
            this.idcartxt.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.photolbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 100);
            this.panel1.TabIndex = 27;
            // 
            // photolbl
            // 
            this.photolbl.AutoSize = true;
            this.photolbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photolbl.ForeColor = System.Drawing.Color.Black;
            this.photolbl.Location = new System.Drawing.Point(12, 41);
            this.photolbl.Name = "photolbl";
            this.photolbl.Size = new System.Drawing.Size(155, 17);
            this.photolbl.TabIndex = 3;
            this.photolbl.Text = "Добавить фотографию";
            // 
            // add_pht
            // 
            this.add_pht.BackColor = System.Drawing.Color.PowderBlue;
            this.add_pht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_pht.ForeColor = System.Drawing.Color.Black;
            this.add_pht.Location = new System.Drawing.Point(120, 334);
            this.add_pht.Name = "add_pht";
            this.add_pht.Size = new System.Drawing.Size(110, 29);
            this.add_pht.TabIndex = 28;
            this.add_pht.Text = "Сохранить";
            this.add_pht.UseVisualStyleBackColor = false;
            this.add_pht.Click += new System.EventHandler(this.add_pht_Click);
            // 
            // add_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 379);
            this.Controls.Add(this.waytxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idcartxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_pht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_photo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_photo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox waytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idcartxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label photolbl;
        private System.Windows.Forms.Button add_pht;
    }
}