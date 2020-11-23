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
    public partial class FormPesan : Form
    {
        public FormPesan()
        {
            InitializeComponent();
            biasaRadioButton.Select();
        }

        private void pesanButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
