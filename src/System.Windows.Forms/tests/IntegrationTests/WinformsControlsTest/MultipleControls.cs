﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace WinformsControlsTest
{
    public partial class MultipleControls : Form
    {
        public MultipleControls()
        {
            InitializeComponent();
        }

        private void Test3_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void MenuStripScaling_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Pennsylvania", CheckState.Checked);
        }
    }
}
