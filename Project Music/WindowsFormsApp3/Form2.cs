using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {public Form2()
        {InitializeComponent();}
        public Form2(Form1 Form1)
        {form1 = Form1;}
        public static string imputText = "";
        private Form1 form1;
        private void button1_Click(object sender, EventArgs e)
        {imputText = textBox1.Text;this.Close(); }
        private void button2_Click(object sender, EventArgs e)
        {this.Close();}
    }
}
