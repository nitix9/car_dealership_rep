
namespace car_dealership
{
    partial class add_type
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
            this.nmtptxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.typelbl = new System.Windows.Forms.Label();
            this.add_tp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmtptxt
            // 
            this.nmtptxt.Location = new System.Drawing.Point(120, 192);
            this.nmtptxt.Name = "nmtptxt";
            this.nmtptxt.Size = new System.Drawing.Size(110, 20);
            this.nmtptxt.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Наименование:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.typelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 100);
            this.panel1.TabIndex = 35;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typelbl.ForeColor = System.Drawing.Color.Black;
            this.typelbl.Location = new System.Drawing.Point(12, 41);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(96, 17);
            this.typelbl.TabIndex = 3;
            this.typelbl.Text = "Добавить тип";
            // 
            // add_tp
            // 
            this.add_tp.BackColor = System.Drawing.Color.PowderBlue;
            this.add_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_tp.ForeColor = System.Drawing.Color.Black;
            this.add_tp.Location = new System.Drawing.Point(120, 342);
            this.add_tp.Name = "add_tp";
            this.add_tp.Size = new System.Drawing.Size(110, 29);
            this.add_tp.TabIndex = 36;
            this.add_tp.Text = "Сохранить";
            this.add_tp.UseVisualStyleBackColor = false;
            this.add_tp.Click += new System.EventHandler(this.add_tp_Click);
            // 
            // add_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 379);
            this.Controls.Add(this.nmtptxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_tp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nmtptxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.Button add_tp;
    }
}