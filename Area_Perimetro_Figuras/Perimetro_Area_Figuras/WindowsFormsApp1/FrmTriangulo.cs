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
    public partial class FrmTriangulo : Form
    {
        private static FrmTriangulo instance;
        public static FrmTriangulo Instance 
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTriangulo();
                }
                return instance;
            }
        }
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {

        }
    }
}
