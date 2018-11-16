﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Member_Time : Form
    {
        Reuse re = new Reuse();
        Label Total;
        Label test;
        Label User_time;
        string User_save;
        string Time_save;

        public Member_Time(string Users, string Time)
        {
            InitializeComponent();
            ClientSize = new Size(1220, 603);
            Load += Member_Time_Load;
            User_save = Users;
            Time_save = Time;
        }

        private void Member_Time_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Member_Panel();
        }

        public void Member_Panel()
        {
            Panel Member_Panel = new Panel();
            Member_Panel.Size = new Size(1220, 603);
            Member_Panel.Location = new Point(0, 0);
            Member_Panel.BackColor = Color.DimGray;
            Member_Panel_1();
            Member_Panel_2();
            this.Controls.Add(Member_Panel);
        }

        public void Member_Panel_1()
        {
            Panel Member_Panel_1 = new Panel();
            Button Member_button_1 = new Button();
            Button Member_button_2 = new Button();
            Button Member_button_3 = new Button();
            Button Member_button_4 = new Button();
            Button Member_button_5 = new Button();
            Button Member_button_6 = new Button();
            //Label Member_Label_1 = new Label();

            Member_Panel_1.Location = new Point(20, 20);
            Member_Panel_1.Size = new Size(585, 565);
            Member_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_1.BackColor = Color.LightGray;
            Member_Panel_1.ForeColor = Color.White;

            re.Plb(Member_Panel_1, " Member_Label_1", "회원 요금제 선택", 275, 50, 165, 15, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 30, FontStyle.Bold);
            //Member_Label_1.Location = new Point(165, 15);
            //Member_Label_1.Size = new Size(265, 50);
            //Member_Label_1.Text = "회원요금제선택";
            //Member_Label_1.BackColor = Color.DimGray;
            //Member_Label_1.TextAlign = ContentAlignment.TopCenter;
            //Member_Label_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Member_button_1.DialogResult = DialogResult.OK;
            Member_button_1.Text = "1,000원\n(적립불가)\n충전 시간 01:00";
            Member_button_1.Size = new Size(200, 140);
            Member_button_1.Location = new Point(90, 90);
            Member_button_1.BackColor = Color.Gray;
            Member_button_1.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_1.Click += Member_button_1_Click;

            Member_button_2.DialogResult = DialogResult.OK;
            Member_button_2.Text = "2,000원\n(적립불가)\n충전 시간 02:00";
            Member_button_2.Size = new Size(200, 140);
            Member_button_2.Location = new Point(310, 90);
            Member_button_2.BackColor = Color.Gray;
            Member_button_2.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_2.Click += Member_button_2_Click;

            Member_button_3.DialogResult = DialogResult.OK;
            Member_button_3.Text = "3,000원\n(적립가능)\n충전 시간 03:00";
            Member_button_3.Size = new Size(200, 140);
            Member_button_3.Location = new Point(90, 250);
            Member_button_3.BackColor = Color.Gray;
            Member_button_3.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_3.Click += Member_button_3_Click;

            Member_button_4.DialogResult = DialogResult.OK;
            Member_button_4.Text = "5,000원\n(적립가능)\n충전 시간 05:30";
            Member_button_4.Size = new Size(200, 140);
            Member_button_4.Location = new Point(310, 250);
            Member_button_4.BackColor = Color.Gray;
            Member_button_4.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_4.Click += Member_button_4_Click;

            Member_button_5.DialogResult = DialogResult.OK;
            Member_button_5.Text = "10,000원\n(적립가능)\n충전 시간 11:00";
            Member_button_5.Size = new Size(200, 140);
            Member_button_5.Location = new Point(90, 410);
            Member_button_5.BackColor = Color.Gray;
            Member_button_5.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_5.Click += Member_button_5_Click;

            Member_button_6.DialogResult = DialogResult.OK;
            Member_button_6.Text = "30,000원\n(적립가능)\n충전 시간 35:00";
            Member_button_6.Size = new Size(200, 140);
            Member_button_6.Location = new Point(310, 410);
            Member_button_6.BackColor = Color.Gray;
            Member_button_6.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_6.Click += Member_button_6_Click;


            this.Controls.Add(Member_Panel_1);
            //Member_Panel_1.Controls.Add(Member_Label_1);
            Member_Panel_1.Controls.Add(Member_button_1);
            Member_Panel_1.Controls.Add(Member_button_2);
            Member_Panel_1.Controls.Add(Member_button_3);
            Member_Panel_1.Controls.Add(Member_button_4);
            Member_Panel_1.Controls.Add(Member_button_5);
            Member_Panel_1.Controls.Add(Member_button_6);


        }
        public void Member_Panel_2()
        {
            Panel Member_Panel_2 = new Panel();
            //Label Member_Label_2 = new Label();
            //Member_Label_3 = new Label();
            Label User = new Label();
            Label Total_money = new Label();
            User_time = new Label();
            Total = new Label();
            test = new Label();


            Button Member_button_7 = new Button();
            Button Member_button_8 = new Button();

            Member_Panel_2.Location = new Point(615, 20);
            Member_Panel_2.Size = new Size(585, 565);
            Member_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_2.BackColor = Color.LightGray;
            Member_Panel_2.ForeColor = Color.White;

            re.Plb(Member_Panel_2, " Member_Label_2", "결제 정보 확인", 245, 50, 170, 15, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            //Member_Label_3.Location = new Point(40, 90);
            //Member_Label_3.Size = new Size(510, 320);
            //Member_Label_3.BackColor = Color.White;
            //Member_Label_3.ForeColor = Color.Black;
            //Member_Label_3.TextAlign = ContentAlignment.TopCenter;
            //Member_Label_3.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            User.Text = string.Format(User_save + " 회원님");
            User.Size = new Size(510, 60);
            User.Location = new Point(40, 90);
            User.BackColor = Color.WhiteSmoke;
            User.ForeColor = Color.Black;
            User.TextAlign = ContentAlignment.MiddleCenter;
            User.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            User_time.Text = string.Format("\n" + Time_save);
            User_time.Size = new Size(510, 170);
            User_time.Location = new Point(40, 150);
            User_time.BackColor = Color.White;
            User_time.ForeColor = Color.Black;
            User_time.TextAlign = ContentAlignment.TopCenter;
            User_time.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            Total_money.Text = "합계 금액";
            Total_money.Size = new Size(260, 80);
            Total_money.Location = new Point(40, 320);
            Total_money.BackColor = Color.White;
            Total_money.ForeColor = Color.Black;
            Total_money.TextAlign = ContentAlignment.MiddleCenter;
            Total_money.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            Total.Text = "0원";
            Total.Size = new Size(250, 80);
            Total.Location = new Point(300, 320);
            Total.BackColor = Color.White;
            Total.ForeColor = Color.IndianRed;
            Total.TextAlign = ContentAlignment.MiddleCenter;
            Total.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            Member_button_7.DialogResult = DialogResult.OK;
            Member_button_7.Text = "현 금";
            Member_button_7.Size = new Size(252, 130);
            Member_button_7.Location = new Point(40, 423);
            Member_button_7.BackColor = Color.SteelBlue;
            Member_button_7.Font = new Font(FontFamily.GenericSansSerif, 40.0F, FontStyle.Bold);
            Member_button_7.Click += Charge_Btn_click;

            Member_button_8.DialogResult = DialogResult.OK;
            Member_button_8.Text = "취 소";
            Member_button_8.Size = new Size(252, 130);
            Member_button_8.Location = new Point(300, 423);
            Member_button_8.BackColor = Color.MediumSeaGreen;
            Member_button_8.Font = new Font(FontFamily.GenericSansSerif, 40.0F, FontStyle.Bold);
            Member_button_8.Click += Cancle_Btn_click;

            this.Controls.Add(Member_Panel_2);

            Member_Panel_2.Controls.Add(User);
            Member_Panel_2.Controls.Add(User_time);
            Member_Panel_2.Controls.Add(Total_money);
            Member_Panel_2.Controls.Add(Total);
            Member_Panel_2.Controls.Add(Member_button_7);
            Member_Panel_2.Controls.Add(Member_button_8);

        }
        public void Member_button_1_Click(object o, EventArgs a)
        {
            if(User_save == "나진욱")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save +"\n충전후 시간 01:34");
            }
            if (User_save == "천호성")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 01:27");
            }
            if (User_save == "김주헌")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 12:23");
            }
            if (User_save == "나훈아")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 17:37");
            }
            if (User_save == "천진반")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 08:03");
            }
            if (User_save == "천호천")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 37:47");
            }
        }
        public void Member_button_2_Click(object o, EventArgs a)
        {
            if (User_save == "나진욱")
            {
                Total.Text = "2,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 02:34");
            }
            if (User_save == "천호성")
            {
                Total.Text = "2,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 02:27");
            }
            if (User_save == "김주헌")
            {
                Total.Text = "2,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 13:23");
            }
            if (User_save == "나훈아")
            {
                Total.Text = "2,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 18:37");
            }
            if (User_save == "천진반")
            {
                Total.Text = "2,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 09:03");
            }
            if (User_save == "천호천")
            {
                Total.Text = "2,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 38:47");
            }
        }
        public void Member_button_3_Click(object o, EventArgs a)
        {
            if (User_save == "나진욱")
            {
                Total.Text = "3,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 03:34");
            }
            if (User_save == "천호성")
            {
                Total.Text = "3,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 03:27");
            }
            if (User_save == "김주헌")
            {
                Total.Text = "3,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 14:23");
            }
            if (User_save == "나훈아")
            {
                Total.Text = "3,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 19:37");
            }
            if (User_save == "천진반")
            {
                Total.Text = "3,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 10:03");
            }
            if (User_save == "천호천")
            {
                Total.Text = "3,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 39:47");
            }
        }
        public void Member_button_4_Click(object o, EventArgs a)
        {
            if (User_save == "나진욱")
            {
                Total.Text = "5,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 06:04");
            }
            if (User_save == "천호성")
            {
                Total.Text = "5,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 05:57");
            }
            if (User_save == "김주헌")
            {
                Total.Text = "5,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 16:53");
            }
            if (User_save == "나훈아")
            {
                Total.Text = "5,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 22:07");
            }
            if (User_save == "천진반")
            {
                Total.Text = "5,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 12:33");
            }
            if (User_save == "천호천")
            {
                Total.Text = "5,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 42:17");
            }
        }
        public void Member_button_5_Click(object o, EventArgs a)
        {
            if (User_save == "나진욱")
            {
                Total.Text = "10,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 11:34");
            }
            if (User_save == "천호성")
            {
                Total.Text = "10,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 11:27");
            }
            if (User_save == "김주헌")
            {
                Total.Text = "1,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 22:23");
            }
            if (User_save == "나훈아")
            {
                Total.Text = "10,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 27:37");
            }
            if (User_save == "천진반")
            {
                Total.Text = "10,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 18:03");
            }
            if (User_save == "천호천")
            {
                Total.Text = "10,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 48:47");
            }
        }
        public void Member_button_6_Click(object o, EventArgs a)
        {
            if (User_save == "나진욱")
            {
                Total.Text = "30,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 35:34");
            }
            if (User_save == "천호성")
            {
                Total.Text = "30,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 35:27");
            }
            if (User_save == "김주헌")
            {
                Total.Text = "30,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 36:23");
            }
            if (User_save == "나훈아")
            {
                Total.Text = "30,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 41:37");
            }
            if (User_save == "천진반")
            {
                Total.Text = "30,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 42:03");
            }
            if (User_save == "천호천")
            {
                Total.Text = "30,000원";
                User_time.Text = string.Format("\n" + Time_save + "\n충전후 시간 71:47");
            }
        }
        private void Charge_Btn_click(object o, EventArgs a)
        {
            Button Member_button_7;
            Member_button_7 = (Button)o;
            this.Close();
            Time_Success mb = new Time_Success();
            mb.Show();
        }

        private void Cancle_Btn_click(object o, EventArgs e)
        {
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = true;
            this.Close();
        }
    }
}