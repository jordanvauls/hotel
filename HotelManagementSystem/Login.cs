﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("MMMM dd, yyyy") + Environment.NewLine + DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length >= 1)
            { textBoxCode.Text = textBoxCode.Text.Remove(textBoxCode.Text.Length - 1); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxCode.Text + "0";
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin("ManagerMenu");
            managerLogin.ShowDialog();
;
            textBoxCode.Text = "";
        }

        private void buttonNosale_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin("NoSale");
            managerLogin.ShowDialog();
            textBoxCode.Text = "";
        }

        private void buttonClockin_Click(object sender, EventArgs e)
        {
            ClockPage clock = new ClockPage();
            clock.ShowDialog();
            textBoxCode.Text = "";
        }

        public void buttonContinue_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text != "")
            {
                Globals.TryLogin(textBoxCode.Text);
                if (Globals.Username != "")
                {
                    int ClockIn = Globals.CheckClock(Globals.Userno, "In");
                    int ClockOut = Globals.CheckClock(Globals.Userno, "Out");
                    if (ClockIn > 0)
                    {
                        if (ClockOut > 0)
                        {
                            MessageBox.Show("You are not Clocked In");
                            textBoxCode.Text = "";
                        }
                       else if(Globals.UserArea.Trim() == "Bar")
                        {
                            Globals.MenuNo = 1;
                            SaleScreen sales = new SaleScreen();
                            sales.ShowDialog();
                            textBoxCode.Text = "";
                            this.Close();
                        }
                        else if (Globals.UserArea.Trim() == "Reception")
                        {
                            Hotel_Manager.Form1 Reception = new Hotel_Manager.Form1();
                            Reception.ShowDialog();
                            this.Close();
                        }
                        else if(Globals.UserArea.Trim() == "Kitchen")
                        {
                            KitchenStock Kitchen = new KitchenStock();
                            Kitchen.ShowDialog();
                            this.Close();
                        }
                        else if (Globals.UserArea.Trim() == "Restaurant")
                        {

                            Restaurant Kitchen = new Restaurant();
                            Kitchen.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are not Clocked In");
                        textBoxCode.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Login Code");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Login Code");
            }
        }


    }
}
