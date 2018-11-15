using System;
using System.Collections;
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
        ArrayList arrayList;
        Button Seat_Btn;
        Reuse re = new Reuse();
        public Main()
        {
            InitializeComponent();
            Load += Main_Load;
            ClientSize = new Size(1220, 603);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            arrayList = new ArrayList();
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel();

        }
        public void Panel()
        {
            panel = new Panel();
            panel.Location = new Point(10, 10);
            panel.Size = new Size(1220, 603);
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
            //Label sbt = new Label();
            //Label test = new Label();

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


            logo.Image = (Bitmap)WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject("schubert");
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.Size = new Size(40, 40);
            logo.Location = new Point(740, 15);

            re.Plb(panel, "sbt", "Schubert PC", 200, 100, 780, 18, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            //sbt.Text = "Schubert PC";
            //sbt.Size = new Size(200, 100);
            //sbt.Location = new Point(760, 18);
            //sbt.Font = new Font(FontFamily.GenericSansSerif, 22F, FontStyle.Bold);
            //sbt.ForeColor = Color.White;

            re.Plb(panel, "Rest_seat", "빈 자리 67좌석", 170, 40, 360, 15, Color.OrangeRed, Color.White, FontFamily.GenericSansSerif, 19, FontStyle.Bold);
            //test.Text = "test 테스트 중입니다!!";
            //test.Size = new Size(300, 100);
            //test.Location = new Point(380, 15);
            //test.Font = new Font(FontFamily.GenericSansSerif, 25F, FontStyle.Bold);
            //test.ForeColor = Color.Yellow;
            re.Plb(panel, "Time", "현재 시간 09:15", 185, 40, 545, 15, Color.Orange, Color.White, FontFamily.GenericSansSerif, 19, FontStyle.Bold);

            Controls.Add(panel);
            panel.Controls.Add(Charge_Btn);
            panel.Controls.Add(Info_Btn);
            panel.Controls.Add(logo);
            //panel.Controls.Add(sbt);
            //panel.Controls.Add(test);
        }

        private void Charge_Btn_click(object o, EventArgs a)
        {
            Button Charge_Btn;
            Charge_Btn = (Button)o;

            Member mb = new Member();
            mb.Show();
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

            Controls.Add(panel);
            Seat();
        }
        public void Panel3()
        {
            panel = new Panel();
            //Label notice = new Label();

            panel.Location = new Point(990, 10);
            panel.Size = new Size(220, 583);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.Gray;

            re.Plb(panel, "notice", "오늘도 저희 PC방을\n찾아오신 고객님께\n감사드립니다." +
                        "\n\nSchubert PC는\n유료 게임 시간 차감을\n별도로 하지 않습니다." +
                        "\n\n문제 발생시 카운터로\n문의해주세요.", 300, 400, 10, 273, Color.Gray, Color.White, FontFamily.GenericSansSerif, 18, FontStyle.Bold);
            //notice.Text = "오늘도 저희 PC방을\n찾아오신 고객님께\n감사드립니다." +
            //    "\n\nSchubert PC는\n유료 게임 시간 차감을\n별도로 하지 않습니다." +
            //    "\n\n문제 발생시 카운터로\n문의해주세요.";
            //notice.Size = new Size(300, 400);
            //notice.Location = new Point(10, 273);
            //notice.Font = new Font(FontFamily.GenericSansSerif, 18.0F, FontStyle.Bold);
            //notice.ForeColor = Color.White;

            Controls.Add(panel);
            //panel.Controls.Add(notice);
        }
        //Button Seat_Btn = new Button();
        public void Seat()
        {
            int count = 1;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Seat_Btn = new Button();
                    Seat_Btn.Size = new Size(85, 60);
                    Seat_Btn.Location = new Point((94 * j) + 19, (69 * i) + 90);
                    Seat_Btn.Name = string.Format("btn{0}", count++);
                    if (Seat_Btn.Name == "btn1" || Seat_Btn.Name == "btn2" || Seat_Btn.Name == "btn15" || Seat_Btn.Name == "btn19" || Seat_Btn.Name == "btn34")
                    {
                        Seat_Btn.BackColor = Color.LimeGreen;
                    }
                    else Seat_Btn.BackColor = Color.DimGray;
                    //arrayList.Add(Seat_Btn);

                    panel.Controls.Add(Seat_Btn);
                    Seat_Btn.Click += Seat_clik;
                }
            }
        }

        private void Seat_clik(object o, EventArgs e)
        {
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Button button = (Button)arrayList[i];
            //    MessageBox.Show(button.Name);
            //}
            Seat_Btn = (Button)o;
            //MessageBox.Show(Seat_Btn.Name);
            Member_Time mt = new Member_Time();
            if (Seat_Btn.BackColor == Color.LimeGreen)
            {
                if (Application.OpenForms["Main"] is Form Main) Main.Visible = false;
                mt.Show();
            }
        }
    }
}