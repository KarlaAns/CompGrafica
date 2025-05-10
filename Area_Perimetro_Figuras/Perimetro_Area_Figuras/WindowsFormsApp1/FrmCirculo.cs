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
    public partial class FrmCirculo : Form
    {
        private static FrmCirculo instance;
        public static FrmCirculo Instance
        {
            get
            { 
                if (instance==null || instance.IsDisposed)
                {
                        instance= new FrmCirculo();
                }
                return instance;
            }
            
        }
        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {

        }
    }
}
