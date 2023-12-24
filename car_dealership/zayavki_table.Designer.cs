
namespace car_dealership
{
    partial class zayavki_table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zayavki_datagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.с1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreinfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zayavki_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.zayavki_datagrid);
            this.panel2.Location = new System.Drawing.Point(34, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 329);
            this.panel2.TabIndex = 6;
            // 
            // zayavki_datagrid
            // 
            this.zayavki_datagrid.AllowUserToAddRows = false;
            this.zayavki_datagrid.AllowUserToDeleteRows = false;
            this.zayavki_datagrid.AllowUserToResizeColumns = false;
            this.zayavki_datagrid.AllowUserToResizeRows = false;
            this.zayavki_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zayavki_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zayavki_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.zayavki_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zayavki_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zayavki_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.с1,
            this.id_car,
            this.id_user,
            this.date,
            this.moreinfo});
            this.zayavki_datagrid.GridColor = System.Drawing.Color.White;
            this.zayavki_datagrid.Location = new System.Drawing.Point(40, 57);
            this.zayavki_datagrid.MultiSelect = false;
            this.zayavki_datagrid.Name = "zayavki_datagrid";
            this.zayavki_datagrid.ReadOnly = true;
            this.zayavki_datagrid.RowHeadersVisible = false;
            this.zayavki_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.zayavki_datagrid.ShowEditingIcon = false;
            this.zayavki_datagrid.Size = new System.Drawing.Size(670, 250);
            this.zayavki_datagrid.TabIndex = 0;
            this.zayavki_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zayavki_datagrid_CellClick);
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
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заявки";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(730, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // с1
            // 
            this.с1.DataPropertyName = "idapplications";
            this.с1.HeaderText = "#";
            this.с1.Name = "с1";
            this.с1.ReadOnly = true;
            this.с1.Visible = false;
            // 
            // id_car
            // 
            this.id_car.DataPropertyName = "id_car";
            this.id_car.HeaderText = "Код машины";
            this.id_car.Name = "id_car";
            this.id_car.ReadOnly = true;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_users";
            this.id_user.HeaderText = "Код пользователя";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // moreinfo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.moreinfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.moreinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreinfo.HeaderText = "";
            this.moreinfo.Name = "moreinfo";
            this.moreinfo.ReadOnly = true;
            this.moreinfo.Text = "Подробнее";
            this.moreinfo.UseColumnTextForButtonValue = true;
            // 
            // zayavki_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "zayavki_table";
            this.Text = "zayavki_table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.zayavki_table_FormClosed);
            this.Shown += new System.EventHandler(this.zayavki_table_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zayavki_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView zayavki_datagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn с1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn moreinfo;
    }
}