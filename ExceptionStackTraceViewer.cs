using System;
using System.Windows.Forms;

namespace ExceptionStackTraceViewer
{
    public partial class ExceptionStackTraceViewer : Form
    {
        public ExceptionStackTraceViewer()
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
            var result = textBox1.Text.Trim()
                                    .Replace("\r\n ", Environment.NewLine)
                                    .Replace("\\r\\n ", Environment.NewLine)
                                    .Replace(" at ", $" {Environment.NewLine}at ")
                                    .Replace("  --- ", $" {Environment.NewLine}{Environment.NewLine}  --- ")
                                    .Replace(" ---> ", $" {Environment.NewLine}{Environment.NewLine} ---> ");
            textBox2.Text = result;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
