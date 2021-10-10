using AnalaizerClass;
using CalcClass;
using CalcExeptionClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        long memoryResult = 0;
        int countTick = 0;
        bool IsFlag = false;
        private bool nonNumberEntered = false;
        public Form1()
        {
            InitializeComponent();
           // Task.Factory.StartNew(Console);
        }

        //private void Console()
        //{
        //    if (AllocConsole())
        //    {
        //        System.Console.WriteLine("Enter expression");
        //        while (true)
        //        {                
        //                string output = System.Console.ReadLine();                
        //                Action action = () => textBox1.Text += output + Environment.NewLine;
        //            if (InvokeRequired)
        //                Invoke(action);
        //            else
        //                action();
        //        }                  
        //    }
        //}

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool AllocConsole();

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool FreeConsole();


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button20.PerformClick();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            textBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            textBox1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            textBox1.Focus();
        }
        //private void DoubleOperator()
        //{
        //    if (textBox1.Text.EndsWith("+") || textBox1.Text.EndsWith("-") || textBox1.Text.EndsWith("*")
        //               || textBox1.Text.EndsWith("/") || textBox1.Text.EndsWith("%"))
        //    {
        //        if (textBox1.Text.Length > 0)
        //        {
        //            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        //        }
        //    }

        //}

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
           // DoubleOperator();
            textBox1.Text += buttonDiv.Text;
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
          //  DoubleOperator();
            textBox1.Text += button14.Text;
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
          //  DoubleOperator();
            textBox1.Text += button15.Text;
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
          //  DoubleOperator();
            textBox1.Text += button16.Text;
            textBox1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
          //  DoubleOperator();
            textBox1.Text += "%";
            textBox1.Focus();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;          
            try
            {
                if (textBox1.Text.Length > 30)
                    throw new ExccedsNumberOperatorException();
                Analaizer.expression = textBox1.Text;
                textBox2.Text = Analaizer.Estimate();
            }
            catch (VeryLongExpressException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (ExccedsNumberOperatorException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (IncompleteExpresException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (IncorrectSyntOftheInputException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (TwoOperatorsException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                textBox2.Text = ex.Message;
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
            }

        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                return;
            memoryResult = 0;
            textBox2.Text = "";
           
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                return;
            memoryResult += Convert.ToInt64(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox2.Text = memoryResult.ToString();
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            textBox1.Focus();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            memoryResult = 0;
        }

        private void buttonOpenBrackets_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button21.Text;
            textBox1.Focus();
        }

        private void buttonCloseBrackets_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            textBox1.Text += button22.Text;
            textBox1.Focus();
        }

        private void buttonAbs_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
           // timer1.Start();
            long res = Convert.ToInt64(textBox2.Text);
            if(res > 0)
              textBox2.Text = Calc.IABS(res).ToString();
            if (res < 0)
                textBox2.Text = Calc.ABS(res).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (countTick < 3)
            //{
            //    IsFlag = false;
            //    countTick++;
            //}
            //else
            //{
            //    timer1.Stop();
            //    countTick = 0;
            //    IsFlag = true;
            //}
        }

       
    }
}
