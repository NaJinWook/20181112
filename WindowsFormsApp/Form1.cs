using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load; // 생성자가 만들어지면서 이것도 실행하면 아래 Form1_Load가 로드된다.
        }

        private Button btn; // btn을 전역으로 쓰겠다라는 의미.

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                btn = new Button();
                btn.DialogResult = DialogResult.OK;

                btn.Text = string.Format("확인 : {0}", (i + 1));
                btn.Size = new Size(100, 50);
                btn.Location = new Point((100 * i) + 30, 30); // 0, 100, 200 만큼 x축을 이동해서 버튼을 옆으로 나열한다.

                btn.Cursor = Cursors.Hand; // 버튼 커서에 마우스를 가져다대면 손가락 모양이 나타난다.

                Controls.Add(btn);
                btn.Click += btn_click;
            }
        }

        private void btn_click(object o, EventArgs a)
        {
            btn = (Button) o; // 버튼은 오브젝트라고 형변환해줘야함
            btn.BackColor = (btn.BackColor == Color.Green) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Green;

            if(btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Silver; // 기본 색상
            }
            else
            {
                btn.BackColor = Color.Green; // 버튼 색깔을 Green으로 지정
            } 
        }
    }
}

