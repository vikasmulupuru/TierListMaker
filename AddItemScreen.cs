﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TierListMaker
{
    public partial class AddItemScreen : Form
    {
        public AddItemScreen()
        {
            InitializeComponent();
        }

        private void CancelAddItemButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKAddItemButton_Click(object sender, EventArgs e)
        {

        }
    }
}
