﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulitboi
{
    public partial class Form35 : Form
    {
        public static Form35 instance;
        public Label lab1, lab2, lab3, lab4, lab5, lab6;
        public Form35()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
            lab2 = label2;
            lab3 = label3;
            lab4 = label4;
            lab5 = label5;
            lab6 = label6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
            this.Hide();
        }
    }
}
