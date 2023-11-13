﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealership
{
    public partial class add_type : Form
    {
        private readonly type_auto _parent;
        public string id, name_types;
        public add_type(type_auto parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            typelbl.Text = "Обновить тип";
            add_tp.Text = "Обновить";
            nmtptxt.Text = name_types;
        }

        public void SaveInfo()
        {
            typelbl.Text = "Добавить тип";
            add_tp.Text = "Сохранить";
            nmtptxt.Text = name_types;
            Clear();
        }

        public void Clear()
        {
            nmtptxt.Text = string.Empty;
        }
        private void add_tp_Click(object sender, EventArgs e)
        {
            if (add_tp.Text == "Сохранить")
            {
                Typeidu tp = new Typeidu(nmtptxt.Text.Trim());
                conn.InsertType(tp);
                Clear();
            }
            if (add_tp.Text == "Обновить")
            {
                Typeidu tp = new Typeidu(nmtptxt.Text.Trim());
                conn.UpdateType(tp, id);
                Clear();
            }
            _parent.Display();
        }

    }
}