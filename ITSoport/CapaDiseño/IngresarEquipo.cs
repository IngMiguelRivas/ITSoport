using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSoport
{
    public partial class IngresarEquipo : Form
    {
        public IngresarEquipo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Form menu = new Menu();
            //menu.Show();
            this.Hide();
        }
    }
}
