﻿using System;
using System.Windows.Forms;

namespace ExceptionStackTraceViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectAll();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.Trim()
                                         .Replace("\r\n ", Environment.NewLine)
                                         .Replace(" at ", $" {Environment.NewLine}at ")
                                         .Replace("  --- ", $" {Environment.NewLine}{Environment.NewLine}  --- ")
                                         .Replace(" ---> ", $" {Environment.NewLine}{Environment.NewLine} ---> ");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
