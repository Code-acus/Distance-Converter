﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Parse the distance value from the text box
            if (!double.TryParse(TextBox1.Text, out double distance))
            {
                
            }
        }
    }
}
