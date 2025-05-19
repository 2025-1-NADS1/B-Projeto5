using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PI
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void dashboard_load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
