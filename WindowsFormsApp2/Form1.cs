﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string a = "1231";
            MessageBox.Show(a);
        }
        public void SaySomething()
        {
            MessageBox.Show("hello");
        }
        public class man
        {
            private string name = "";
            private int age = 15;
        }
    }
}
