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
    public partial class Non_Member_Time : Form
    {
        public Non_Member_Time()
        {
            InitializeComponent();
            ClientSize = new Size(1200, 620);
            BackColor = Color.DimGray;
            Non_Member_Panel_1();
            Non_Member_Panel_2();
        }
        Label Member_Label_3;

        public void Non_Member_Panel_1()
        {
            Panel Member_Panel_1 = new Panel();
            Button Member_button_1 = new Button();
            Button Member_button_2 = new Button();
            Button Member_button_3 = new Button();
            Button Member_button_4 = new Button();

            Label Member_Label_1 = new Label();
            Label Member_Label_2 = new Label();

            Member_Panel_1.Location = new Point(10, 10);
            Member_Panel_1.Size = new Size(585, 600);
            Member_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_1.BackColor = Color.LightGray;
            Member_Panel_1.ForeColor = Color.White;

            Member_Label_1.Location = new Point(165, 15);
            Member_Label_1.Size = new Size(265, 50);
            Member_Label_1.Text = "비회원 요금제 선택";
            Member_Label_1.BackColor = Color.DimGray;
            Member_Label_1.TextAlign = ContentAlignment.TopCenter;
            Member_Label_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Member_Label_2.Location = new Point(90, 470);
            Member_Label_2.Size = new Size(565, 80);
            Member_Label_2.Text = "X 비회원님은 시간 적립 대상이 아닙니다.";
            // Member_Label_2.BackColor = Color.Blue;
            Member_Label_2.ForeColor = Color.Red;
            Member_Label_2.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            Member_button_1.DialogResult = DialogResult.OK;
            Member_button_1.Text = "1,000원\r\n(적립불가)\r\n충전시간 00:50";
            Member_button_1.Size = new Size(200, 150);
            Member_button_1.Location = new Point(90, 90);
            Member_button_1.BackColor = Color.Silver;
            Member_button_1.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_1.Click += Member_button_1_Click;

            Member_button_2.DialogResult = DialogResult.OK;
            Member_button_2.Text = "2,000원\r\n(적립불가)\r\n충전시간 01:40";
            Member_button_2.Size = new Size(200, 150);
            Member_button_2.Location = new Point(310, 90);
            Member_button_2.BackColor = Color.Silver;
            Member_button_2.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_2.Click += Member_button_2_Click;

            Member_button_3.DialogResult = DialogResult.OK;
            Member_button_3.Text = "3,000원\r\n(적립불가)\r\n충전시간 02:30";
            Member_button_3.Size = new Size(200, 150);
            Member_button_3.Location = new Point(90, 260);
            Member_button_3.BackColor = Color.Silver;
            Member_button_3.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_3.Click += Member_button_3_Click;

            Member_button_4.DialogResult = DialogResult.OK;
            Member_button_4.Text = "5,000원\r\n(적립불가)\r\n충전시간 05:00";
            Member_button_4.Size = new Size(200, 150);
            Member_button_4.Location = new Point(310, 260);
            Member_button_4.BackColor = Color.Silver;
            Member_button_4.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_4.Click += Member_button_4_Click;


            this.Controls.Add(Member_Panel_1);
            Member_Panel_1.Controls.Add(Member_Label_1);
            Member_Panel_1.Controls.Add(Member_button_1);
            Member_Panel_1.Controls.Add(Member_button_2);
            Member_Panel_1.Controls.Add(Member_button_3);
            Member_Panel_1.Controls.Add(Member_button_4);
            Member_Panel_1.Controls.Add(Member_Label_2);

            // item1 = new Label("");
        }

        public void Non_Member_Panel_2()
        {
            Panel Member_Panel_2 = new Panel();
            Label Member_Label_2 = new Label();
            Member_Label_3 = new Label();
            Button Member_button_7 = new Button();
            Button Member_button_8 = new Button();

            Member_Panel_2.Location = new Point(605, 10);
            Member_Panel_2.Size = new Size(585, 600);
            Member_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_2.BackColor = Color.LightGray;
            Member_Panel_2.ForeColor = Color.White;

            Member_Label_2.Location = new Point(165, 15);
            Member_Label_2.Size = new Size(265, 50);
            Member_Label_2.Text = "결제 정보 확인";
            Member_Label_2.BackColor = Color.DimGray;
            Member_Label_2.TextAlign = ContentAlignment.TopCenter;
            Member_Label_2.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Member_Label_3.Location = new Point(40, 90);
            Member_Label_3.Size = new Size(510, 320);
            Member_Label_3.BackColor = Color.White;
            Member_Label_3.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
            Member_Label_3.ForeColor = Color.Black;
            Member_Label_3.TextAlign = ContentAlignment.TopCenter;
            Member_Label_3.Click += Member_button_1_Click;

            Member_button_7.DialogResult = DialogResult.OK;
            Member_button_7.Text = "현금";
            Member_button_7.Size = new Size(200, 150);
            Member_button_7.Location = new Point(90, 430);
            Member_button_7.BackColor = Color.SteelBlue;
            Member_button_7.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_7.Click += Charge_Btn_click;


            Member_button_8.DialogResult = DialogResult.OK;
            Member_button_8.Text = "취소";
            Member_button_8.Size = new Size(200, 150);
            Member_button_8.Location = new Point(310, 430);
            Member_button_8.BackColor = Color.MediumSeaGreen;
            Member_button_8.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            this.Controls.Add(Member_Panel_2);
            Member_Panel_2.Controls.Add(Member_Label_2);
            Member_Panel_2.Controls.Add(Member_Label_3);
            Member_Panel_2.Controls.Add(Member_button_7);
            Member_Panel_2.Controls.Add(Member_button_8);

        }
        public void Member_button_1_Click(object o, EventArgs a)
        {
            Member_Label_3.Text = "\r\n충전시간 00:50\r\n\r\n\r\n\r\n합계금액 1,000원";
        }
        public void Member_button_2_Click(object o, EventArgs a)
        {
            Member_Label_3.Text = "\r\n충전시간 01:40\r\n\r\n\r\n\r\n합계금액 2,000원";
        }
        public void Member_button_3_Click(object o, EventArgs a)
        {
            Member_Label_3.Text = "\r\n충전시간 02:30\r\n\r\n\r\n\r\n합계금액 3,000원";
        }
        public void Member_button_4_Click(object o, EventArgs a)
        {
            Member_Label_3.Text = "\r\n충전시간 05:00\r\n\r\n\r\n\r\n합계금액 5,000원";
        }
        public void Member_button_7_Click(object o, EventArgs a)
        {
            Member_Label_3.Text = "\r\n충전시간 05:00\r\n\r\n\r\n\r\n합계금액 5,000원";
        }
        private void Charge_Btn_click(object o, EventArgs a)
        {
            Button Member_button_7;
            Member_button_7 = (Button)o;

            Time_Success mb = new Time_Success();
            mb.ShowDialog();
        }
    }
}
