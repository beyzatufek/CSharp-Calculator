using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private char _islem;
        private bool _ifClearScreen;
        private int _ilkSayi;



        private void button0_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "0";
            }
            else
            {
                labelEkran.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "1";
            }
            else
            {
                labelEkran.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "2";
            }
            else
            {
                labelEkran.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "3";
            }
            else
            {
                labelEkran.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "4";
            }
            else
            {
                labelEkran.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "5";
            }
            else
            {
                labelEkran.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "6";
            }
            else
            {
                labelEkran.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "7";
            }
            else
            {
                labelEkran.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "8";
            }
            else
            {
                labelEkran.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ifClearScreen)
            {
                labelEkran.Text = "";
                _ifClearScreen = false;
            }
            if (labelEkran.Text == "0")
            {
                labelEkran.Text = "";
                labelEkran.Text = "9";
            }
            else
            {
                labelEkran.Text += "9";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelEkran.Text = "0";
        }

        private void buttonEsit_Click(object sender, EventArgs e)
        {
            int sonuc;
            int ikinciSayi = Convert.ToInt32(labelEkran.Text);
            
            switch (_islem)
            {
                case '-':
                    sonuc = _ilkSayi - Convert.ToInt32(labelEkran.Text);
                    
                    break;
                case '+':
                    sonuc = _ilkSayi + Convert.ToInt32(labelEkran.Text);
                    
                    break;
                case '*':
                    sonuc = _ilkSayi * Convert.ToInt32(labelEkran.Text);
                    
                    break;
                case '/':
                    sonuc = _ilkSayi / Convert.ToInt32(labelEkran.Text);
                    
                    break;
                default:
                    sonuc = 0;
                    break;

            }
            labelEkran.Text = sonuc.ToString();
        }

            private void buttonBol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ifClearScreen = true;
            _ilkSayi = Convert.ToInt32(labelEkran.Text);
           


            
        }

        private void buttonCarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ifClearScreen = true;
            _ilkSayi = Convert.ToInt32(labelEkran.Text);
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ifClearScreen = true;
            _ilkSayi = Convert.ToInt32(labelEkran.Text);
        }

        private void buttonArtı_Click(object sender, EventArgs e)
        {
            
            _islem = '+';
            _ifClearScreen = true;
            _ilkSayi = Convert.ToInt32(labelEkran.Text);


        }
    }
}
