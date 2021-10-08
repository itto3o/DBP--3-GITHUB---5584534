using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_과제3_GITHUB_김서지_5584534
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            printHelloWorld();
        }

        private void printHelloWorld()
        {
            TextBox textBox = new TextBox();
            textBox.Text = "Hello World.";

            Controls.Add(textBox);
        }
    }
}
