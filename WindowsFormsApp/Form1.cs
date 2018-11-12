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

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;

            btn.Text = "확인"; // 버튼안에 확인이라는 글씨 입력
            btn.Size = new Size(100, 50); // 버튼 사이즈 (100, 50)지정
            btn.Location = new Point(30, 30); // 버튼의 위치 지정

            Controls.Add(btn); // 화면에 등록하기
            btn.Click += btn_click; // += 는 추가한다라는 의미
        }

        private void btn_click(object o, EventArgs a)
        {
            MessageBox.Show("확인하기!");
        }
    }
}

