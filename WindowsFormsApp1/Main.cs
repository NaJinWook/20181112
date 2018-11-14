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
    public partial class Main : Form
    {
        Panel panel;
        public Main()
        {
            InitializeComponent();
            Load += Main_Load;
            ClientSize = new Size(1220, 603);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(100, 100);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel();
            
        }
        public void Panel()
        {
            panel = new Panel();
            panel.Location = new Point(10, 10);
            panel.Size = new Size(1220, 620);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.BackColor = Color.DarkGray;
            Panel1();
            Panel2();
            Panel3();
        }
        public void Panel1()
        {
            panel = new Panel();
            Button Charge_Btn = new Button();
            Button Info_Btn = new Button();
            PictureBox logo = new PictureBox();
            Label sbt = new Label();
            Label test = new Label();


            panel.Location = new Point(10, 10);
            panel.Size = new Size(970, 75);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.BackColor = Color.DimGray;

            Charge_Btn.DialogResult = DialogResult.OK;
            Charge_Btn.Text = "회원/비회원 충전";
            Charge_Btn.Size = new Size(150, 50);
            Charge_Btn.Location = new Point(20, 10);
            Charge_Btn.BackColor = Color.LightGray;
            Charge_Btn.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Charge_Btn.Click += Charge_Btn_click;

            Info_Btn.DialogResult = DialogResult.OK;
            Info_Btn.Text = "사용회원 검색";
            Info_Btn.Size = new Size(150, 50);
            Info_Btn.Location = new Point(190, 10);
            Info_Btn.BackColor = Color.LightGray;
            Info_Btn.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Info_Btn.Click += Info_Btn_click;

            

            //logo.Image = Bitmap.FromFile(@"C:\schubert.png");
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.Size = new Size(50, 50);
            logo.Location = new Point(700, 10);

            sbt.Text = "Schubert PC";
            sbt.Size = new Size(200, 100);
            sbt.Location = new Point(760, 18);
            sbt.Font = new Font(FontFamily.GenericSansSerif, 22.0F, FontStyle.Bold);
            sbt.ForeColor = Color.White;

            test.Text = "test 테스트 중입니다!!";
            test.Size = new Size(300, 100);
            test.Location = new Point(380, 15);
            test.Font = new Font(FontFamily.GenericSansSerif, 25.0F, FontStyle.Bold);
            test.ForeColor = Color.Yellow;

            Controls.Add(panel);
            panel.Controls.Add(Charge_Btn);
            panel.Controls.Add(Info_Btn);
            panel.Controls.Add(logo);
            panel.Controls.Add(sbt);
            panel.Controls.Add(test);


        }

        private void Charge_Btn_click(object o, EventArgs a)
        {
            Button Charge_Btn;
            Charge_Btn = (Button)o;

            Member mb = new Member();
            mb.ShowDialog();
        }
        private void Info_Btn_click(object o, EventArgs a)
        {
            Button Info_Btn;
            Info_Btn = (Button)o;
            Search sc = new Search();
            sc.ShowDialog();

        }
        public void Panel2()
        {
            panel = new Panel();
            Button seat = new Button();

            panel.Location = new Point(10, 10);
            panel.Size = new Size(970, 583);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.Gray;

            //for (int i = 0; i < 10; i++)
            //{
            //    seat.Size = new Size(80, 50);
            //    seat.Location = new Point((15*i)+ 15, 85);
            //    seat.BackColor = Color.Red;
            //    panel.Controls.Add(seat);
            //}
            Controls.Add(panel);
            Seat();

        }
        public void Panel3()
        {
            panel = new Panel();
            Label notice = new Label();

            panel.Location = new Point(990, 10);
            panel.Size = new Size(220, 583);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.Gray;

            notice.Text = "오늘도 저희 PC방을\n찾아오신 고객님께\n감사드립니다." +
                "\n\nSchubert PC는\n유료 게임 시간 차감을\n별도로 하지 않습니다." +
                "\n\n문제 발생시 카운터로\n문의해주세요.";
            notice.Size = new Size(300, 400);
            notice.Location = new Point(10, 273);
            notice.Font = new Font(FontFamily.GenericSansSerif, 18.0F, FontStyle.Bold);
            notice.ForeColor = Color.White;

            Controls.Add(panel);
            panel.Controls.Add(notice);
        }

        private void Seat()
        {
            for(int i=0; i<7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button Seat_Btn = new Button();
                    Seat_Btn.Size = new Size(85, 60);
                    Seat_Btn.Location = new Point((94 * j) + 19, (69 * i) + 90);
                    Seat_Btn.BackColor = Color.DimGray;
                    
                    panel.Controls.Add(Seat_Btn);
                }
            }
        }
    }
}