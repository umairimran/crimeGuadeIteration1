﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class personalBelongingsManagementPortal : Form
    {
        public personalBelongingsManagementPortal()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            create_new_belonging g = new create_new_belonging();
            g.Show();
        }
    }
}
