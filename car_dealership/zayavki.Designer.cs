
namespace car_dealership
{
    partial class zayavki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zayavki));
            this.name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.otchestvo = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.lastntxtbx = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.otchtxt = new System.Windows.Forms.TextBox();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(122, 176);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Имя:";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.BackColor = System.Drawing.Color.Transparent;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_name.ForeColor = System.Drawing.Color.White;
            this.last_name.Location = new System.Drawing.Point(85, 131);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(78, 16);
            this.last_name.TabIndex = 1;
            this.last_name.Text = "Фамилия:";
            // 
            // otchestvo
            // 
            this.otchestvo.AutoSize = true;
            this.otchestvo.BackColor = System.Drawing.Color.Transparent;
            this.otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvo.ForeColor = System.Drawing.Color.White;
            this.otchestvo.Location = new System.Drawing.Point(80, 217);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(83, 16);
            this.otchestvo.TabIndex = 2;
            this.otchestvo.Text = "Отчество:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.ForeColor = System.Drawing.Color.White;
            this.number.Location = new System.Drawing.Point(84, 257);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(79, 16);
            this.number.TabIndex = 3;
            this.number.Text = "Телефон:";
            // 
            // lastntxtbx
            // 
            this.lastntxtbx.Location = new System.Drawing.Point(164, 127);
            this.lastntxtbx.Name = "lastntxtbx";
            this.lastntxtbx.Size = new System.Drawing.Size(100, 20);
            this.lastntxtbx.TabIndex = 4;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(164, 172);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 5;
            // 
            // otchtxt
            // 
            this.otchtxt.Location = new System.Drawing.Point(164, 213);
            this.otchtxt.Name = "otchtxt";
            this.otchtxt.Size = new System.Drawing.Size(100, 20);
            this.otchtxt.TabIndex = 6;
            // 
            // numbertxt
            // 
            this.numbertxt.Location = new System.Drawing.Point(164, 253);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(100, 20);
            this.numbertxt.TabIndex = 7;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Black;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(134, 309);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(156, 23);
            this.send.TabIndex = 8;
            this.send.Text = "Отправить заявку";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.send);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.otchtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.lastntxtbx);
            this.Controls.Add(this.number);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "zayavki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zayavki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label otchestvo;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox lastntxtbx;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox otchtxt;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.Button send;
    }
}