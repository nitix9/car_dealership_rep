
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
            this.name.Location = new System.Drawing.Point(76, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(32, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Имя:";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(49, 67);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(59, 13);
            this.last_name.TabIndex = 1;
            this.last_name.Text = "Фамилия:";
            // 
            // otchestvo
            // 
            this.otchestvo.AutoSize = true;
            this.otchestvo.Location = new System.Drawing.Point(51, 139);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(57, 13);
            this.otchestvo.TabIndex = 2;
            this.otchestvo.Text = "Отчество:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(12, 172);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(96, 13);
            this.number.TabIndex = 3;
            this.number.Text = "Номер телефона:";
            // 
            // lastntxtbx
            // 
            this.lastntxtbx.Location = new System.Drawing.Point(114, 60);
            this.lastntxtbx.Name = "lastntxtbx";
            this.lastntxtbx.Size = new System.Drawing.Size(100, 20);
            this.lastntxtbx.TabIndex = 4;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(114, 98);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 5;
            // 
            // otchtxt
            // 
            this.otchtxt.Location = new System.Drawing.Point(114, 132);
            this.otchtxt.Name = "otchtxt";
            this.otchtxt.Size = new System.Drawing.Size(100, 20);
            this.otchtxt.TabIndex = 6;
            // 
            // numbertxt
            // 
            this.numbertxt.Location = new System.Drawing.Point(114, 165);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(100, 20);
            this.numbertxt.TabIndex = 7;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(129, 306);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(121, 23);
            this.send.TabIndex = 8;
            this.send.Text = "Отправить заявку";
            this.send.UseVisualStyleBackColor = true;
            // 
            // zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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