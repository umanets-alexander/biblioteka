﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class CategoryAddEditingForm : Form
    {
        public CategoryAddEditingForm()
        {
            InitializeComponent();
        }

        private void CategoryAddEditingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
