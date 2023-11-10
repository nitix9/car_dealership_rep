
namespace car_dealership
{
    partial class add_hist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.histlbl = new System.Windows.Forms.Label();
            this.add_histsl = new System.Windows.Forms.Button();
            this.datestxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idustxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idcartxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.histlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 100);
            this.panel1.TabIndex = 3;
            // 
            // histlbl
            // 
            this.histlbl.AutoSize = true;
            this.histlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.histlbl.ForeColor = System.Drawing.Color.Black;
            this.histlbl.Location = new System.Drawing.Point(12, 41);
            this.histlbl.Name = "histlbl";
            this.histlbl.Size = new System.Drawing.Size(189, 17);
            this.histlbl.TabIndex = 3;
            this.histlbl.Text = "Добавить запись о продаже";
            // 
            // add_histsl
            // 
            this.add_histsl.BackColor = System.Drawing.Color.PowderBlue;
            this.add_histsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_histsl.ForeColor = System.Drawing.Color.Black;
            this.add_histsl.Location = new System.Drawing.Point(120, 319);
            this.add_histsl.Name = "add_histsl";
            this.add_histsl.Size = new System.Drawing.Size(110, 29);
            this.add_histsl.TabIndex = 6;
            this.add_histsl.Text = "Сохранить";
            this.add_histsl.UseVisualStyleBackColor = false;
            this.add_histsl.Click += new System.EventHandler(this.add_histsl_Click);
            // 
            // datestxt
            // 
            this.datestxt.Location = new System.Drawing.Point(120, 226);
            this.datestxt.Name = "datestxt";
            this.datestxt.Size = new System.Drawing.Size(110, 20);
            this.datestxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата продажи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Код пользователя:";
            // 
            // idustxt
            // 
            this.idustxt.Location = new System.Drawing.Point(120, 159);
            this.idustxt.Name = "idustxt";
            this.idustxt.Size = new System.Drawing.Size(110, 20);
            this.idustxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Код машины:";
            // 
            // idcartxt
            // 
            this.idcartxt.Location = new System.Drawing.Point(120, 193);
            this.idcartxt.Name = "idcartxt";
            this.idcartxt.Size = new System.Drawing.Size(110, 20);
            this.idcartxt.TabIndex = 21;
            // 
            // add_hist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 379);
            this.Controls.Add(this.datestxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idustxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idcartxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_histsl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_hist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_hist";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label histlbl;
        private System.Windows.Forms.Button add_histsl;
        private System.Windows.Forms.TextBox datestxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idustxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idcartxt;
    }
}