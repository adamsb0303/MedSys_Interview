﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedSys_Interview
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void addButton_Click(object sender, EventArgs e) {
            itemListBox.Items.Add(itemTextBox.Text);
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
    }
}
