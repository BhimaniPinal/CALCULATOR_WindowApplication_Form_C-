using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a, b, c, d;
        public Form1()
        {
            InitializeComponent();
        }



        private void button14_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            //textBox2.Text = "";
            textBox1.Text = textBox1.Text + "0";
            textBox2.Text = textBox2.Text + "0";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            // textBox2.Text = "";
            textBox1.Text = textBox1.Text + "1";
            textBox2.Text = textBox2.Text + "1";
        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox2.Text = "";
            textBox1.Text = textBox1.Text + "2";
            textBox2.Text = textBox2.Text + "2";
        }

        private void button23_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            //textBox2.Text = "";
            textBox1.Text = textBox1.Text + "3";
            textBox2.Text = textBox2.Text + "3";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            // textBox2.Text = "";
            textBox1.Text = textBox1.Text + "4";
            textBox2.Text = textBox2.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox2.Text = "";
            textBox1.Text = textBox1.Text + "5";
            textBox2.Text = textBox2.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox2.Text = "";
            textBox1.Text = textBox1.Text + "6";
            textBox2.Text = textBox2.Text + "6";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            // textBox2.Text = "";
            textBox1.Text = textBox1.Text + "7";
            textBox2.Text = textBox2.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            //textBox2.Text = "";
            textBox1.Text = textBox1.Text + "8";
            textBox2.Text = textBox2.Text + "8";
        }
        private void button7_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            // textBox2.Text = "";
            textBox1.Text = textBox1.Text + "9";
            textBox2.Text = textBox2.Text + "9";

        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox2.Text = textBox2.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            c = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            if (b == '/')
            {
                if (c == 0)
                {
                    textBox1.Text = "Error";
                    textBox2.Text = "cannot devide by zero";
                }
                else
                {
                    d = a / c;
                    textBox1.Text += d;
                    textBox2.Text = textBox2.Text + "=" + d;
                    a = d;
                }
            }
            else if (b == '+')
            {
                d = a + c;
                textBox1.Text += d;
                textBox2.Text = textBox2.Text + "=" + d;
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                textBox1.Text += d;
                textBox2.Text = textBox2.Text + "=" + d;
                a = d;
            }
            else if (b == '%')
            {
                d = a % c;
                textBox1.Text += d;
                textBox2.Text = textBox2.Text + "=" + d;
            }
            else
            {
                d = a * c;
                textBox1.Text += d;
                textBox2.Text = textBox2.Text + "=" + d;
                a = d;
            }
        }
        private void button16_Click(object sender, EventArgs e)  // + (add)s
        {
            textBox2.Text = textBox2.Text + "+";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            b = '+';
            // textBox1.Text += b;

        }
        private void button22_Click(object sender, EventArgs e)  //  -(sub) 
        {
            textBox2.Text = textBox2.Text + "-";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            b = '-';
            // textBox1.Text += b;
        }

        private void button13_Click(object sender, EventArgs e)  // * (mul)
        {
            textBox2.Text = textBox2.Text + "*";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            b = '*';
            //textBox1.Text += b;
        }

        private void button8_Click(object sender, EventArgs e)  // /(div)
        {
            textBox2.Text = textBox2.Text + "/";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            b = '/';
            // textBox1.Text += b; 
        }

        private void button3_Click(object sender, EventArgs e)  // - (sign)
        {
            textBox2.Text = "-" + textBox1.Text;
            textBox1.Text = "-" + textBox1.Text;
            //textBox1.Text += b;
        }

        private void button18_Click(object sender, EventArgs e)  // Backspace
        {
            if(b=='+'||b=='-'||b=='*'||b=='%'||b=='/')
            {
                b = '\0';
                textBox1.Text = "";
            }
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)  //C
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)  //CE
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)  //Sqrt
        {
            textBox2.Text = "sqrt(" + textBox1.Text + ")";
            a = Convert.ToInt32(textBox1.Text);
            double d = Math.Sqrt(a);
            textBox1.Text = Convert.ToString(d);
            textBox2.Text = textBox2.Text + "=" + d;

        }

        private void button9_Click(object sender, EventArgs e)  // %
        {
            textBox2.Text = textBox2.Text + "%";
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            b = '%';
            // textBox1.Text += b; 
        }
        private void button20_Click(object sender, EventArgs e)  //1/x
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(1 / a);
            textBox2.Text = "(1/" + Convert.ToString(a) + ")=" + textBox1.Text;
        }



        private void button25_Click(object sender, EventArgs e)  //MC
        {
            textBox2.Text = "";
            textBox1.Text = "";
            d = 0;
        }

        private void button28_Click(object sender, EventArgs e)  //MS
        {
            d = Convert.ToInt32(textBox1.Text);
            textBox2.Text = "M=" + textBox1.Text;
            textBox1.Text = "";
        }

        private void button26_Click(object sender, EventArgs e)  //M-
        {
            d = d - Convert.ToInt32(textBox1.Text);
            textBox2.Text = "M=" + Convert.ToString(d);
            textBox1.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)  //M+
        {
            d = d + Convert.ToInt32(textBox1.Text);
            textBox2.Text = "M=" + Convert.ToString(d);
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)  //MR
        {
            textBox1.Text = Convert.ToString(d);
            textBox2.Text = "M" + Convert.ToString(d);
        }
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)//Copy context manu
        {
            textBox1.Copy();
            textBox2.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)//past context manu 
        {
            textBox1.Paste();
            textBox2.Paste();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text.Contains < String >= "=";
        }

       

        private void standedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Show();
            f.MdiParent = this;//set ismdi in form1
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Show();
            f.MdiParent = this;//set ismdi in form1
        }
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //helpProvider1;
        }


        private void aboutClaculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form help = new Form();
            help.Show();
            help.Name = "help";
            addtextbox();*/
            MessageBox.Show("An electronic calculator is typically a portable" +
            "electronic device used to perform calculations, ranging" +
            "from basic arithmetic to complex mathematics. The first " +
            "solid state electronic calculator was created in the early" +
            "1960s.The pocket sized devices became available in the" +
             " 1970s,especially after the first microprocessor");
            

        }
        /*
        public Control  addtextbox()
        {
            TextBox t = new TextBox();
            t.Multiline = true;
            t.Top = 4;
            // t.Bottom = 4;
            t.Left = 4;
            // t.Right = 4;
            t.Text = "An electronic calculator is typically a portable" +
            "electronic device used to perform calculations, ranging" +
            "from basic arithmetic to complex mathematics. The first " +
            "solid state electronic calculator was created in the early" +
            "1960s.The pocket sized devices became available in the" +
             " 1970s,especially after the first microprocessor, the ...";
        }
        */
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
              textBox1.Copy();
              textBox2.Copy();
        }
        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            textBox1.Paste();
           textBox2.Paste();
        }

        private void pastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TextBox t = new TextBox();
           // String a = Clipboard.GetText();
           // t.Text = t.Text.Insert(t.SelectionStart, a);//past at select pointer 
           // textBox1.Cut();
           // textBox2.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

           // TextBox t = new TextBox();
           // Clipboard.SetText(t.Text);//copy all the text of textbox
           // Clipboard.SetText(textBox1.SelectedText);// cut selected text
           // textBox1.SelectedText = String.Empty;   
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }

}
