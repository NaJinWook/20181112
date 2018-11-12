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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Panel();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public void Panel()
        {
            Panel panel1 = new Panel();
            Label ID_label = new Label();
            TextBox Content = new TextBox();
            Button Search_Btn = new Button();
            Label Seat_Num = new Label();
            Label Name = new Label();
            Label userID = new Label();
            ListView Search_View = new ListView();

            panel1.Location = new Point(10, 10);
            panel1.Size = new Size(590, 280);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            ID_label.Text = "회원 ID / 이름";
            ID_label.Size = new Size(165, 30);
            ID_label.Location = new Point(30, 30);
            ID_label.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            Content.Text = "";
            Content.Size = new Size(260, 200);
            Content.Location = new Point(210, 30);
            Content.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            Search_Btn.Text = "검색";
            Search_Btn.Size = new Size(70, 40);
            Search_Btn.Location = new Point(470, 29);
            Search_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Search_Btn.BackColor = Color.Black;
            Search_Btn.ForeColor = Color.White;

            Seat_Num.Text = "좌석 번호";
            Seat_Num.Size = new Size(100, 30);
            Seat_Num.Location = new Point(70, 80);
            Seat_Num.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Name.Text = "이름";
            Name.Size = new Size(100, 30);
            Name.Location = new Point(250, 80);
            Name.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            userID.Text = "회원 ID";
            userID.Size = new Size(100, 30);
            userID.Location = new Point(410, 80);
            userID.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            Search_View.Size = new Size(550, 150);
            Search_View.Location = new Point(20, 110);

            this.Controls.Add(panel1);
            panel1.Controls.Add(ID_label);
            panel1.Controls.Add(Content);
            panel1.Controls.Add(Search_Btn);
            panel1.Controls.Add(Seat_Num);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(userID);
            panel1.Controls.Add(Search_View);
        }
    }
}
