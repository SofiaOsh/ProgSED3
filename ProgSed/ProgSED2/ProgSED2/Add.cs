﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgSED2
{
    public partial class Add : Form
    {
        public Add(List<CDocument> doc)
        {
            InitializeComponent();
        }

        private void buttonClick_Save(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}