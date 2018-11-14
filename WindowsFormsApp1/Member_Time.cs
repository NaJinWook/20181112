using System;
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
        public Member_Time()
        {
            InitializeComponent();
            ClientSize = new Size(1020, 720);
            BackColor = Color.SteelBlue;
            Member_Panel_1();
            Member_Panel_2();
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
            Label Member_Label_1 = new Label();

            Member_Panel_1.Location = new Point(10, 10);
            Member_Panel_1.Size = new Size(485, 700);
            Member_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_1.BackColor = Color.LightGray;
            Member_Panel_1.ForeColor = Color.White;

            Member_Label_1.Location = new Point(115, 55);
            Member_Label_1.Size = new Size(265, 50);
            Member_Label_1.Text = "회원요금제선택";
            Member_Label_1.BackColor = Color.Blue;
            Member_Label_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Member_button_1.DialogResult = DialogResult.OK;
            Member_button_1.Text = "1,000원\r\n(적립불가)\r\n충전시간01:00";
            Member_button_1.Size = new Size(200, 150);
            Member_button_1.Location = new Point(20, 150);
            Member_button_1.BackColor = Color.Silver;
            Member_button_1.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Member_button_2.DialogResult = DialogResult.OK;
            Member_button_2.Text = "2,000원\r\n(적립불가)\r\n충전시간02:00";
            Member_button_2.Size = new Size(200, 150);
            Member_button_2.Location = new Point(265, 150);
            Member_button_2.BackColor = Color.Silver;
            Member_button_2.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Member_button_3.DialogResult = DialogResult.OK;
            Member_button_3.Text = "3,000원\r\n(적립가능)\r\n충전시간03:00";
            Member_button_3.Size = new Size(200, 150);
            Member_button_3.Location = new Point(20, 330);
            Member_button_3.BackColor = Color.Silver;
            Member_button_3.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Member_button_4.DialogResult = DialogResult.OK;
            Member_button_4.Text = "5,000원\r\n(적립가능)\r\n충전시간05:30";
            Member_button_4.Size = new Size(200, 150);
            Member_button_4.Location = new Point(265, 330);
            Member_button_4.BackColor = Color.Silver;
            Member_button_4.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Member_button_5.DialogResult = DialogResult.OK;
            Member_button_5.Text = "10,000원\r\n(적립가능)\r\n충전시간11:00";
            Member_button_5.Size = new Size(200, 150);
            Member_button_5.Location = new Point(20, 510);
            Member_button_5.BackColor = Color.Silver;
            Member_button_5.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Member_button_6.DialogResult = DialogResult.OK;
            Member_button_6.Text = "30,000원\r\n(적립가능)\r\n충전시간35:00";
            Member_button_6.Size = new Size(200, 150);
            Member_button_6.Location = new Point(265, 510);
            Member_button_6.BackColor = Color.Silver;
            Member_button_6.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);


            this.Controls.Add(Member_Panel_1);
            Member_Panel_1.Controls.Add(Member_Label_1);
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
            Label Member_Label_2 = new Label();
            Label Member_Label_3 = new Label();
            Button Member_button_7 = new Button();
            Button Member_button_8 = new Button();

            Member_Panel_2.Location = new Point(525, 10);
            Member_Panel_2.Size = new Size(485, 700);
            Member_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_2.BackColor = Color.LightGray;
            Member_Panel_2.ForeColor = Color.White;

            Member_Label_2.Location = new Point(115, 55);
            Member_Label_2.Size = new Size(265, 50);
            Member_Label_2.Text = "회원요금제선택";
            Member_Label_2.BackColor = Color.Blue;
            Member_Label_2.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Member_Label_3.Location = new Point(60, 150);
            Member_Label_3.Size = new Size(380, 330);
            Member_Label_3.BackColor = Color.White;
            Member_Label_3.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Member_button_7.DialogResult = DialogResult.OK;
            Member_button_7.Text = "현금";
            Member_button_7.Size = new Size(150, 150);
            Member_button_7.Location = new Point(75, 510);
            Member_button_7.BackColor = Color.SteelBlue;
            Member_button_7.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Member_button_8.DialogResult = DialogResult.OK;
            Member_button_8.Text = "취소";
            Member_button_8.Size = new Size(150, 150);
            Member_button_8.Location = new Point(275, 510);
            Member_button_8.BackColor = Color.MediumSeaGreen;
            Member_button_8.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            this.Controls.Add(Member_Panel_2);
            Member_Panel_2.Controls.Add(Member_Label_2);
            Member_Panel_2.Controls.Add(Member_Label_3);
            Member_Panel_2.Controls.Add(Member_button_7);
            Member_Panel_2.Controls.Add(Member_button_8);

        }


    }
}
