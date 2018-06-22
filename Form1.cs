using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timer
{
    public partial class MForm : Form
    {
        int mls;
        int sec;
        int min;
        int hours;
        int mls_t, sec_t, min_t, hours_t;

        bool isCounter;
        bool isCounter_Tim;
        int window;
        MessageBoxButtons buttons = MessageBoxButtons.OK;


        public MForm()
        {
            InitializeComponent();
            mls = 0;
            sec = 0;
            min = 0;
            hours = 0;

            mls_t = 0;
            sec_t = 0;
            min_t = 0;
            hours_t = 0;
            isCounter = false;
            isCounter_Tim = false;
            timer1.Start();
            window = 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(window == 1)
            {
                isCounter = !isCounter;
            }

            else
            {
                isCounter_Tim = !isCounter_Tim;

                if (isCounter_Tim == true)
                {
                    H_text.ReadOnly = true;
                    S_text.ReadOnly = true;
                    M_text.ReadOnly = true;
                    ML_text.ReadOnly = true;

                    if (H_text.Text.Length == 0 || M_text.Text.Length == 0 || S_text.Text.Length == 0 || ML_text.Text.Length == 0)
                    {
                        SystemSounds.Beep.Play();



                        H_text.ReadOnly = false;
                        S_text.ReadOnly = false;
                        M_text.ReadOnly = false;
                        ML_text.ReadOnly = false;


                        isCounter_Tim = false;
                        MessageBox.Show("Некоторые поля пустые!", "Таймер", buttons);

                    }

                    else
                    {
                        hours_t = Convert.ToInt32(H_text.Text);
                        min_t = Convert.ToInt32(M_text.Text);
                        sec_t = Convert.ToInt32(S_text.Text);
                        mls_t = Convert.ToInt32(ML_text.Text);
                    }

                    int tmp;

                    if(mls_t > 9)
                    {
                        sec_t = mls_t / 10;
                        mls_t = mls_t - sec_t * 10;
                    }

                    if(sec_t > 59)
                    {
                        min_t = sec_t / 60;
                        sec_t = sec_t - min_t * 60;
                    }

                    if (min_t > 59)
                    {
                        hours_t = min_t / 60;
                        min_t = min_t - hours_t * 60;
                    }


                }


                if ((hours_t == 0) && (min_t == 0) && (sec_t == 0) && (mls_t == 0) && isCounter_Tim == true)
                {

                    SystemSounds.Beep.Play();


                    H_text.ReadOnly = false;
                    S_text.ReadOnly = false;
                    M_text.ReadOnly = false;
                    ML_text.ReadOnly = false;

                    isCounter_Tim = false;

                    MessageBox.Show("Все введенные значения равны нулю!", "Таймер", buttons);

                }

                else
                {
                    H_text.ReadOnly = false;
                    S_text.ReadOnly = false;
                    M_text.ReadOnly = false;
                    ML_text.ReadOnly = false;
                }






            }
            
            

            

            


        }

        private void sec_butt_CheckedChanged(object sender, EventArgs e)
        {
            window = 1;
            this.Text = "Секундомер";

            disc.Visible = false;

            H_text.ReadOnly = true;
            S_text.ReadOnly = true;
            M_text.ReadOnly = true;
            ML_text.ReadOnly = true;

        }

        private void wathc_butt_CheckedChanged(object sender, EventArgs e)
        {
            window = 3;
            this.Text = "Часы";

            H_text.ReadOnly = true;
            S_text.ReadOnly = true;
            M_text.ReadOnly = true;
            ML_text.ReadOnly = true;

        }

        private void sec_abort_Click(object sender, EventArgs e)
        {


            H_text.Text = "0";
            S_text.Text = "0";
            M_text.Text = "0";
            ML_text.Text = "0";
            
            if(window == 1)
            {
                mls = 0;
                min = 0;
                hours = 0;
                sec = 0;

                isCounter = false;
            }

            else
            {
                mls_t = 0;
                min_t = 0;
                hours_t = 0;
                sec_t = 0;

                isCounter_Tim = false;
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCounter == true)
            {
                mls += 1;

                if(mls > 9)
                {
                    mls = 0;
                    sec += 1;
                }

                if(sec > 59)
                {
                    sec = 0;
                    min += 1;
                }

                if (min > 59)
                {
                    min = 0;
                    hours += 1;
                }

            }

            if(isCounter_Tim == true)
            {
                mls_t -= 1;

                if(mls_t < 0)
                {
                    bool ch = true;

                    if (sec_t != 0)
                    {
                        sec_t -= 1;
                        mls_t = 10;
                        ch = false;
                    }

                    if(min_t != 0 && ch == true)
                    {
                        sec_t = 59;
                        min_t -= 1;
                        ch = false;
                        mls_t = 10;
                    }

                    if (hours_t != 0 && ch == true)
                    {
                        sec_t = 59;
                        min_t = 59;
                        hours_t -= 1;
                        mls_t = 10;
                        ch = false;
                    }

                    if(ch == true)
                    {
                        mls_t = 0;

                        SystemSounds.Beep.Play();
                        isCounter_Tim = false;

                        MessageBox.Show("Время вышло!", "Таймер", buttons);

                       

                    }
                  
                }

            }


           switch(window)
            {
                case 1:
                    H_text.Text = hours.ToString();
                    S_text.Text = sec.ToString();
                    M_text.Text = min.ToString();
                    ML_text.Text = mls.ToString();
                    break;

                case 2:
                    if(isCounter_Tim == true)
                    {
                        H_text.Text = hours_t.ToString();
                        S_text.Text = sec_t.ToString();
                        M_text.Text = min_t.ToString();
                        ML_text.Text = mls_t.ToString();
                    }
                    
                    break;


                case 3:

                    break;
            }

           


            timer1.Start();
        }

        private void tim_butt_CheckedChanged(object sender, EventArgs e)
        {
            window = 2;
            this.Text = "Таймер";
            disc.Visible = true;

            H_text.ReadOnly = false;
            S_text.ReadOnly = false;
            M_text.ReadOnly = false;
            ML_text.ReadOnly = false;

            H_text.Text = "0";
            S_text.Text = "0";
            M_text.Text = "0";
            ML_text.Text = "0";
        }
    }
}
