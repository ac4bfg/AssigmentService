using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigmentService.View
{
    public partial class PageProfil : UserControl
    {
/*        FrmDasboard dasboard = new FrmDasboard();*/
        public PageProfil()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
/*            dasboard.btnSimpan.Enabled = true;*/
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
