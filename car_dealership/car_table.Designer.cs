
namespace car_dealership
{
    partial class auto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.car_datagrid = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(726, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
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
            this.panel2.Controls.Add(this.car_datagrid);
            this.panel2.Location = new System.Drawing.Point(34, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 329);
            this.panel2.TabIndex = 6;
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
            // car_datagrid
            // 
            this.car_datagrid.AllowUserToAddRows = false;
            this.car_datagrid.AllowUserToDeleteRows = false;
            this.car_datagrid.AllowUserToResizeColumns = false;
            this.car_datagrid.AllowUserToResizeRows = false;
            this.car_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.car_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.car_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.car_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.car_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.car_datagrid.GridColor = System.Drawing.Color.White;
            this.car_datagrid.Location = new System.Drawing.Point(40, 57);
            this.car_datagrid.MultiSelect = false;
            this.car_datagrid.Name = "car_datagrid";
            this.car_datagrid.ReadOnly = true;
            this.car_datagrid.RowHeadersVisible = false;
            this.car_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.car_datagrid.ShowEditingIcon = false;
            this.car_datagrid.Size = new System.Drawing.Size(670, 250);
            this.car_datagrid.TabIndex = 0;
            this.car_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.car_datagrid_CellClick);
            // 
            // с1
            // 
            this.с1.DataPropertyName = "id";
            this.с1.HeaderText = "#";
            this.с1.Name = "с1";
            this.с1.ReadOnly = true;
            this.с1.Visible = false;
            // 
            // c2
            // 
            this.c2.DataPropertyName = "number";
            this.c2.HeaderText = "Номер";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // с3
            // 
            this.с3.DataPropertyName = "brand";
            this.с3.HeaderText = "Марка";
            this.с3.Name = "с3";
            this.с3.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.DataPropertyName = "model";
            this.c4.HeaderText = "Модель";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "year_release";
            this.c5.HeaderText = "Год выпуска";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // c6
            // 
            this.c6.DataPropertyName = "id_types";
            this.c6.HeaderText = "Код типа";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            // 
            // c7
            // 
            this.c7.DataPropertyName = "cost";
            this.c7.HeaderText = "Стоимость";
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            // 
            // c8
            // 
            this.c8.DataPropertyName = "discription";
            this.c8.HeaderText = "Описание";
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            // 
            // Columnbt1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Columnbt1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Columnbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Columnbt1.HeaderText = "";
            this.Columnbt1.Name = "Columnbt1";
            this.Columnbt1.ReadOnly = true;
            this.Columnbt1.Text = "Изменить";
            this.Columnbt1.UseColumnTextForButtonValue = true;
            // 
            // Columnbt2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Columnbt2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Columnbt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Columnbt2.HeaderText = "";
            this.Columnbt2.Name = "Columnbt2";
            this.Columnbt2.ReadOnly = true;
            this.Columnbt2.Text = "Удалить";
            this.Columnbt2.UseColumnTextForButtonValue = true;
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
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Автомобили";
            // 
            // auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "auto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "car";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.auto_FormClosed);
            this.Shown += new System.EventHandler(this.auto_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView car_datagrid;
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