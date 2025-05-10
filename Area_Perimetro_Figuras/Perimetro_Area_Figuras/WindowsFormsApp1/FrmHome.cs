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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirc= FrmCirculo.Instance;
            frmCirc.MdiParent = this;
            if(!frmCirc.Visible)
            {
                frmCirc.Show();
            }
            else
            {
                frmCirc.BringToFront();
            }
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuad = FrmCuadrado.Instance;
            frmCuad.MdiParent = this;
            if (!frmCuad.Visible)
            {
                frmCuad.Show();
            }
            else
            {
                frmCuad.BringToFront();
            }

        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTri = FrmTriangulo.Instance;
            frmTri.MdiParent = this;
            if (!frmTri.Visible)
            {
                frmTri.Show();
            }
            else
            {
                frmTri.BringToFront();
            }
        }
    }
}
