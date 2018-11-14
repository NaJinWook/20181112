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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            ClientSize = new Size(610, 300);
            MaximizeBox = false;
            Load += Search_Load;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(300, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Panel();
        }

        public void Panel()
        {
            Panel panel1 = new Panel();
            Label ID_label = new Label();
            TextBox Content = new TextBox();
            Button Search_Btn = new Button();
            ListView Search_View = new ListView();

            panel1.Location = new Point(10, 10);
            panel1.Size = new Size(590, 280);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panel1.BackColor = Color.DimGray;

            ID_label.Text = "회원 ID / 이름";
            ID_label.Size = new Size(165, 30);
            ID_label.Location = new Point(30, 30);
            ID_label.ForeColor = Color.White;
            ID_label.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            Content.Text = "";
            Content.Size = new Size(260, 200);
            Content.Location = new Point(210, 30);
            Content.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            Search_Btn.Text = "검색";
            Search_Btn.Size = new Size(70, 40);
            Search_Btn.Location = new Point(470, 29);
            Search_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Search_Btn.BackColor = Color.DimGray;
            Search_Btn.ForeColor = Color.White;
            Search_Btn.Click += Search_Btn_click;

            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            Search_View.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Search_View.BackColor = Color.WhiteSmoke;
            Search_View.Font = new Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Bold);

            columnHeader1.Text = "순번";
            columnHeader1.Width = 40;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            columnHeader2.Text = "좌석 번호";
            columnHeader2.Width = 170;
            columnHeader2.TextAlign = HorizontalAlignment.Center;

            columnHeader3.Text = "이름";
            columnHeader3.Width = 170;
            columnHeader3.TextAlign = HorizontalAlignment.Center;

            columnHeader4.Text = "회원 ID";
            columnHeader4.Width = 170;
            columnHeader4.TextAlign = HorizontalAlignment.Center;

            Search_View.GridLines = true;
            Search_View.Size = new Size(550, 160);
            Search_View.Location = new Point(20, 100);
            Search_View.TabIndex = 0;
            Search_View.UseCompatibleStateImageBehavior = false;
            Search_View.View = View.Details;

            ListViewItem item1 = new ListViewItem();
            ListViewItem item2 = new ListViewItem();
            ListViewItem item3 = new ListViewItem();
            ListViewItem item4 = new ListViewItem();
            Search_View.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });


            Controls.Add(panel1);
            panel1.Controls.Add(ID_label);
            panel1.Controls.Add(Content);
            panel1.Controls.Add(Search_Btn);
            //panel1.Controls.Add(Seat_Num);
            //panel1.Controls.Add(Name);
            //panel1.Controls.Add(userID);
            panel1.Controls.Add(Search_View);

        }
        public void Search_Btn_click(object o, EventArgs a)
        {
            Button Search_Btn;
            Search_Btn = (Button)o;
            MessageBox.Show("클릭성공");
        }
    }
}