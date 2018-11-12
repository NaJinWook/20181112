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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button Charge_Btn = new Button();
            Charge_Btn.DialogResult = DialogResult.OK;
            Charge_Btn.Text = "회원/비회원 충전";
            Charge_Btn.Size = new Size(150, 50);
            Charge_Btn.Location = new Point(50, 30);
            Charge_Btn.BackColor = Color.Silver;
            Charge_Btn.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Controls.Add(Charge_Btn);
            Charge_Btn.Click += Charge_Btn_click;

            Button Info_Btn = new Button();
            Info_Btn.DialogResult = DialogResult.OK;
            Info_Btn.Text = "사용회원 검색";
            Info_Btn.Size = new Size(150, 50);
            Info_Btn.Location = new Point(210, 30);
            Info_Btn.BackColor = Color.Black;
            Info_Btn.ForeColor = Color.White;
            Info_Btn.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Controls.Add(Info_Btn);
            Info_Btn.Click += Info_Btn_click;
        }
        private void Charge_Btn_click(object o, EventArgs a)
        {
            Button Charge_Btn;
            Charge_Btn = (Button)o;
            MessageBox.Show("회원/비회원 버튼 폼으로 이동합니다.","Schubert PC");
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void Info_Btn_click(object o, EventArgs a)
        {
            Button Info_Btn;
            Info_Btn = (Button)o;
            MessageBox.Show("사용회원 검색 폼으로 이동합니다.","Schubert Pc");
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }
    }
}
