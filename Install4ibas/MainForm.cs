﻿using Install4ibas.UI;
using System;
using System.Windows.Forms;

namespace Install4ibas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var control=new WelcomeControl();
            this.shellControl1.SetCurrentControl(control);
        }

    }
}