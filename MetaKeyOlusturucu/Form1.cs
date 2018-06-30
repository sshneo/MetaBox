using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaKeyOlusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             @author:
             @developer:Halil ŞAHİN
             
             */
            richTextBox1.Text += "<html>\n";
            richTextBox1.Text += "<head>\n";

            richTextBox1.Text += "<meta http - equiv = \"Content - Type\" content = \"text  html; charset  utf-8\" />\n";

            richTextBox1.Text +="< meta name = \"viewport\" content = \"width=device-width, initial-scale=1.0\">";
               richTextBox1.Text += "<title>" + textBox1.Text + "</title>\n";
            richTextBox1.Text += "<meta name=\"keywords\" content=" + textBox2.Text + ">\n";
            richTextBox1.Text += "<meta name=\"description\" content=" + textBox3.Text + ">\n";
            richTextBox1.Text += "<meta http-equiv=\"refresh\" content=" + MetaRefresh.Text + ">\n";

            richTextBox1.Text += "</head>\n";
            richTextBox1.Text += "<body>\n";
            richTextBox1.Text += "</html>\n";

            button2.Visible = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MetaRefresh.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        public void Gogogo(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
