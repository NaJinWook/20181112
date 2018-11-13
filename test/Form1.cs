using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label notice = new Label();
            notice.Text = "오늘도 저희 PC방을 찾아오신 고객님께 감사드립니다." +
                "\n\nSchubert PC는 유료 게임 시간 차감을 별도로 하지 않습니다." +
                "\n\n문제 발생시 카운터로 문의해주세요.";

            notice.Size = new Size(300, 300);
            notice.Location = new Point(1000, 15);
            notice.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            notice.ForeColor = Color.Black;

            Controls.Add(notice);
        }

        
        

    }
}
