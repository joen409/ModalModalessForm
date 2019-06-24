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
    public partial class FormModaless : Form
    {
        public string Title
        {
            set { this.Text = value; }
        }

        public FormModaless()
        {
            InitializeComponent();
        }
        private void ShowModal()
        {
            this.statusMessage.Text = "모달창을 띄웁니다.";
            FormModal f = new FormModal();
            f.Title = "모달리스창";
            f.Show();
        }
    }
}
