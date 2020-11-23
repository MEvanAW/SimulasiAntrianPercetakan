using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulasiAntrianPercetakan
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bukaAntrianButton_Click(object sender, EventArgs e)
        {
            new FormAntrian().Show();
        }

        private void berkasTercetakButton_Click(object sender, EventArgs e)
        {
            new FormBerkasTercetak().Show();
        }
    }
}
