using System;
using System.Windows.Forms;
using Calculator;

namespace Calculadora
{
    public partial class UserControl1 : UserControl
    {

        string last = null;
        String operation = "";
        public UserControl1()
        {
            InitializeComponent();
            label1.Text = "";
        }
        #region numbers
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += ".";
        }
        #endregion


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalculator myCalculator = new MyCalculator(textBoxRes.Text);
                var operationResult = myCalculator.SolveWithHierarchy();
                textBoxRes.Text = operationResult;
                label1.Text = myCalculator.last;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        MyCalculator myCalculatorBasic = new MyCalculator();
        string operationActive;
        public void ExecuteOperation()
        {
            switch (operationActive)
            {
                case "res":
                    label1.Text = $"{myCalculatorBasic.a} - {myCalculatorBasic.b}";
                    myCalculatorBasic.Res();
                    break;
                case "sum":
                    label1.Text = $"{myCalculatorBasic.a} + {myCalculatorBasic.b}";
                    myCalculatorBasic.Sum();
                    break;
                case "multi":
                    label1.Text = $"{myCalculatorBasic.a} x {myCalculatorBasic.b}";
                    myCalculatorBasic.Multi();
                    break;
                case "div":
                    label1.Text = $"{myCalculatorBasic.a} / {myCalculatorBasic.b}";
                    myCalculatorBasic.Div();
                    break;
                case "mod":
                    label1.Text = $"{myCalculatorBasic.a} % {myCalculatorBasic.b}";
                    myCalculatorBasic.Mod();
                    break;
            }
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.checkBox1.Checked)
                {
                    if (this.last == null)
                    {
                        myCalculatorBasic.a = double.Parse(textBoxRes.Text);
                        this.last = textBoxRes.Text;
                        label1.Text = this.last.ToString();
                        textBoxRes.Text = "";
                        operationActive = "sum";
                    }
                    else
                    {
                        myCalculatorBasic.b = double.Parse(textBoxRes.Text);
                        ExecuteOperation();
                        myCalculatorBasic.a = myCalculatorBasic.lastInt;
                        label1.Text += $" = {myCalculatorBasic.lastInt}";
                        textBoxRes.Text = "";
                        operationActive = "sum";
                    }
                }
                else
                {
                    textBoxRes.Text += "+";
                }
            }
            catch (Exception) { }
        }
        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.checkBox1.Checked)
                {
                    if (this.last == null)
                    {
                        myCalculatorBasic.a = double.Parse(textBoxRes.Text);
                        this.last = textBoxRes.Text;
                        label1.Text = this.last.ToString();
                        textBoxRes.Text = "";
                        operationActive = "res";
                    }
                    else
                    {
                        myCalculatorBasic.b = double.Parse(textBoxRes.Text);
                        ExecuteOperation();
                        myCalculatorBasic.a = myCalculatorBasic.lastInt;
                        label1.Text += $" = {myCalculatorBasic.lastInt}";
                        textBoxRes.Text = "";
                        operationActive = "res";
                    }
                }
                else
                {
                    textBoxRes.Text += "-";
                }

            }
            catch (Exception) { }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.checkBox1.Checked)
                {
                    if (this.last == null)
                    {
                        myCalculatorBasic.a = double.Parse(textBoxRes.Text);
                        this.last = textBoxRes.Text;
                        label1.Text = this.last.ToString();
                        textBoxRes.Text = "";
                        operationActive = "multi";
                    }
                    else
                    {
                        myCalculatorBasic.b = double.Parse(textBoxRes.Text);
                        ExecuteOperation();
                        myCalculatorBasic.a = myCalculatorBasic.lastInt;
                        textBoxRes.Text += $" = {myCalculatorBasic.lastInt}";
                        textBoxRes.Text = "";
                        operationActive = "multi";
                    }
                }
                else
                {
                    textBoxRes.Text += "*";
                }

            }
            catch (Exception) { }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (!this.checkBox1.Checked)
            {
                if (this.last == null)
                {
                    myCalculatorBasic.a = double.Parse(textBoxRes.Text);
                    this.last = textBoxRes.Text;
                    label1.Text = this.last.ToString();
                    textBoxRes.Text = "";
                    operationActive = "div";
                }
                else
                {
                    myCalculatorBasic.b = double.Parse(textBoxRes.Text);
                    ExecuteOperation();
                    myCalculatorBasic.a = myCalculatorBasic.lastInt;
                    label1.Text += $" = {myCalculatorBasic.lastInt}";
                    textBoxRes.Text = "";
                    operationActive = "div";
                }
            }
            else
            {
                textBoxRes.Text += "/";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
            this.last = null;
            label1.Text = "";
        }
        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (!this.checkBox1.Checked)
            {
                if (this.last == null)
                {
                    myCalculatorBasic.a = double.Parse(textBoxRes.Text);
                    this.last = textBoxRes.Text;
                    label1.Text = this.last.ToString();
                    textBoxRes.Text = "";
                    operationActive = "mod";
                }
                else
                {
                    myCalculatorBasic.b = double.Parse(textBoxRes.Text);
                    ExecuteOperation();
                    myCalculatorBasic.a = myCalculatorBasic.lastInt;
                    label1.Text += $" = {myCalculatorBasic.lastInt}";
                    textBoxRes.Text = "";
                    operationActive = "mod";
                }
            }
            else
            {
                textBoxRes.Text += "%";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRes.Text = textBoxRes.Text.Remove(textBoxRes.Text.Length - 1, 1);
            }
            catch (Exception) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
            this.last = null;
            label1.Text = "";
        }
    }
}
