
namespace car_dealership
{
    partial class user_table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.user_datagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.с1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnbt1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Columnbt2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.user_datagrid);
            this.panel2.Location = new System.Drawing.Point(34, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 329);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(40, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_datagrid
            // 
            this.user_datagrid.AllowUserToAddRows = false;
            this.user_datagrid.AllowUserToDeleteRows = false;
            this.user_datagrid.AllowUserToResizeColumns = false;
            this.user_datagrid.AllowUserToResizeRows = false;
            this.user_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.user_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.с1,
            this.c2,
            this.с3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.Columnbt1,
            this.Columnbt2});
            this.user_datagrid.GridColor = System.Drawing.Color.White;
            this.user_datagrid.Location = new System.Drawing.Point(40, 57);
            this.user_datagrid.MultiSelect = false;
            this.user_datagrid.Name = "user_datagrid";
            this.user_datagrid.ReadOnly = true;
            this.user_datagrid.RowHeadersVisible = false;
            this.user_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.user_datagrid.ShowEditingIcon = false;
            this.user_datagrid.Size = new System.Drawing.Size(670, 250);
            this.user_datagrid.TabIndex = 0;
            this.user_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_datagrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 131);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пользователи";
            // 
            // с1
            // 
            this.с1.DataPropertyName = "id";
            this.с1.HeaderText = "#";
            this.с1.Name = "с1";
            this.с1.ReadOnly = true;
            // 
            // c2
            // 
            this.c2.DataPropertyName = "last_name";
            this.c2.HeaderText = "Фамилия";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // с3
            // 
            this.с3.DataPropertyName = "name";
            this.с3.HeaderText = "Имя";
            this.с3.Name = "с3";
            this.с3.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.DataPropertyName = "patronymic";
            this.c4.HeaderText = "Отчество";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "adress";
            this.c5.HeaderText = "Адрес";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // c6
            // 
            this.c6.DataPropertyName = "mobile_phone";
            this.c6.HeaderText = "Номер телефона";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            // 
            // c7
            // 
            this.c7.DataPropertyName = "password";
            this.c7.HeaderText = "Пароль";
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            // 
            // c8
            // 
            this.c8.DataPropertyName = "id_roles";
            this.c8.HeaderText = "Код роли";
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            // 
            // Columnbt1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Columnbt1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Columnbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Columnbt1.HeaderText = "";
            this.Columnbt1.Name = "Columnbt1";
            this.Columnbt1.ReadOnly = true;
            this.Columnbt1.Text = "Изменить";
            this.Columnbt1.UseColumnTextForButtonValue = true;
            // 
            // Columnbt2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Columnbt2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Columnbt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Columnbt2.HeaderText = "";
            this.Columnbt2.Name = "Columnbt2";
            this.Columnbt2.ReadOnly = true;
            this.Columnbt2.Text = "Удалить";
            this.Columnbt2.UseColumnTextForButtonValue = true;
            // 
            // user_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "user_table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.user_table_FormClosed);
            this.Shown += new System.EventHandler(this.user_table_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView user_datagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn с1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn с3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewButtonColumn Columnbt1;
        private System.Windows.Forms.DataGridViewButtonColumn Columnbt2;
    }
}