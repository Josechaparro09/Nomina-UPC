using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fManual = new frRegistro();
            fManual.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnGAle_Click(object sender, EventArgs e)
        {
            var fAle = new GeneradorUI();
            fAle.ShowDialog();
        }
    }
}
