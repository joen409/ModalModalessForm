using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "종료합니다";
            Application.ExitThread();
        }

        private void ModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private void ShowModal()
        {
            this.statusMessage.Text = "모달창을 띄웁니다.";
            FormModal f = new FormModal();
            f.Title = "모달창";
            f.ShowDialog();
        }

        private void ShowModaless()
        {
            this.statusMessage.Text = "모달리스창을 띄웁니다.";
            FormModaless f = new FormModaless();
            f.Title = "모달리스창";
            f.ShowDialog();
        }

        private void BtmModal_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            ShowModaless();
        }

        private void 이프로그램은ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은..(Modal)";
            FormAbout f = new FormAbout();
            f.Title = "이 프로그램은..(Modal)";
            f.ShowDialog();
        }

        private void 이프로그램은ModalessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은..(Modaless)";
            FormAbout f = new FormAbout();
            f.Title = "이 프로그램은..(Modaless)";
            f.Show();
        }
    }
}
