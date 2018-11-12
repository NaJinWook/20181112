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
            //Label ID_label = new Label();
            //ID_label.Text = "회원 ID / 이름";
            //ID_label.Size = new Size(165, 30);
            //ID_label.Location = new Point(30, 30);
            //Controls.Add(ID_label);
            //ID_label.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            //TextBox Content = new TextBox();
            //Content.Size = new Size(200, 200);
            //Content.Location = new Point(210, 30);
            //Content.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            //Controls.Add(Content);

            //Button Search_Btn = new Button();
            //Search_Btn.Text = "검색";
            //Search_Btn.Size = new Size(70, 40);
            //Search_Btn.Location = new Point(410, 29);
            //Controls.Add(Search_Btn);
            //Search_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            //Search_Btn.BackColor = Color.Black;
            //Search_Btn.ForeColor = Color.White;
            
        }

        public void Panel()
        {
            Panel panel1 = new Panel();
            Label ID_label = new Label();
            TextBox Content = new TextBox();
            Button Search_Btn = new Button();

            panel1.Location = new Point(10, 10);
            panel1.Size = new Size(780, 430);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            ID_label.Text = "회원 ID / 이름";
            ID_label.Size = new Size(165, 30);
            ID_label.Location = new Point(30, 30);
            ID_label.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Content.Text = "";
            Content.Size = new Size(200, 200);
            Content.Location = new Point(210, 30);
            Content.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Search_Btn.Text = "검색";
            Search_Btn.Size = new Size(70, 40);
            Search_Btn.Location = new Point(410, 29);
            Search_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Search_Btn.BackColor = Color.Black;
            Search_Btn.ForeColor = Color.White;

            this.Controls.Add(panel1);
            panel1.Controls.Add(ID_label);
            panel1.Controls.Add(Content);
            panel1.Controls.Add(Search_Btn);
        }
    }
}
