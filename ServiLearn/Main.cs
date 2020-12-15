using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiLearn
{
    public partial class Main : Form
    {
        private Cuenta cuenta;

        public Main(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
