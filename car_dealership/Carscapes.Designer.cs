﻿
namespace car_dealership
{
    partial class osnova
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osnova));
            this.log_box = new System.Windows.Forms.TextBox();
            this.pas_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_but = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.hidepas = new System.Windows.Forms.PictureBox();
            this.showpas = new System.Windows.Forms.PictureBox();
            this.reg = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.hidepas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpas)).BeginInit();
            this.SuspendLayout();
            // 
            // log_box
            // 
            this.log_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_box.Location = new System.Drawing.Point(400, 177);
            this.log_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(265, 22);
            this.log_box.TabIndex = 1;
            // 
            // pas_box
            // 
            this.pas_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pas_box.Location = new System.Drawing.Point(400, 244);
            this.pas_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pas_box.Name = "pas_box";
            this.pas_box.Size = new System.Drawing.Size(265, 22);
            this.pas_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // log_but
            // 
            this.log_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_but.BackColor = System.Drawing.Color.Black;
            this.log_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_but.ForeColor = System.Drawing.Color.White;
            this.log_but.Location = new System.Drawing.Point(428, 329);
            this.log_but.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.log_but.Name = "log_but";
            this.log_but.Size = new System.Drawing.Size(200, 38);
            this.log_but.TabIndex = 5;
            this.log_but.Text = "ВОЙТИ";
            this.log_but.UseVisualStyleBackColor = false;
            this.log_but.Click += new System.EventHandler(this.log_but_Click);
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(400, 286);
            this.user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(122, 21);
            this.user.TabIndex = 6;
            this.user.TabStop = true;
            this.user.Text = "Пользователь";
            this.user.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.user.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(539, 286);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(132, 21);
            this.Admin.TabIndex = 7;
            this.Admin.TabStop = true;
            this.Admin.Text = "Администратор";
            this.Admin.UseVisualStyleBackColor = false;
            // 
            // hidepas
            // 
            this.hidepas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hidepas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidepas.BackgroundImage")));
            this.hidepas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidepas.Location = new System.Drawing.Point(675, 244);
            this.hidepas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hidepas.Name = "hidepas";
            this.hidepas.Size = new System.Drawing.Size(43, 26);
            this.hidepas.TabIndex = 8;
            this.hidepas.TabStop = false;
            this.hidepas.Click += new System.EventHandler(this.hidepas_Click);
            // 
            // showpas
            // 
            this.showpas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showpas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showpas.BackgroundImage")));
            this.showpas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showpas.Location = new System.Drawing.Point(675, 244);
            this.showpas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showpas.Name = "showpas";
            this.showpas.Size = new System.Drawing.Size(43, 26);
            this.showpas.TabIndex = 9;
            this.showpas.TabStop = false;
            this.showpas.Click += new System.EventHandler(this.showpas_Click);
            // 
            // reg
            // 
            this.reg.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reg.AutoSize = true;
            this.reg.BackColor = System.Drawing.Color.Transparent;
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg.LinkColor = System.Drawing.Color.White;
            this.reg.Location = new System.Drawing.Point(443, 383);
            this.reg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(151, 18);
            this.reg.TabIndex = 10;
            this.reg.TabStop = true;
            this.reg.Text = "Зарегистрироваться";
            this.reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkClicked);
            // 
            // osnova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.showpas);
            this.Controls.Add(this.hidepas);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.user);
            this.Controls.Add(this.log_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pas_box);
            this.Controls.Add(this.log_box);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "osnova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carscapes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hidepas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.TextBox pas_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log_but;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.PictureBox hidepas;
        private System.Windows.Forms.PictureBox showpas;
        private System.Windows.Forms.LinkLabel reg;
    }
}

