using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BDLibrary;

namespace ServiLearn
{
    public partial class PreviewCurso : Form
    {
        private Cuenta user;
        private int tipo;
        private Curso curso;
        public PreviewCurso(Cuenta u, int t, Curso c)
        {
            user = u;
            tipo = t;
            curso = c;
            InitializeComponent();
            Cuenta cuenta = new Cuenta(curso.IdOwner);



            if (tipo == 0)
            {
                bInscribirse.Visible = false;
            }

            lCurso.Text = ("Curso: " + c.Nombre);
            lImp.Text = ("Organizado por: " + cuenta.Nombre);
            tbDesc.Text = c.Descripcion;
        }
        private void InsertarCuentaEnCurso(Cuenta cuenta, Curso curso)
        {
            MySQLDB miBD = new MySQLDB();

            int idCuenta = cuenta.id;
            int idCurso = curso.Id;

            miBD.Insert("INSERT INTO Cuenta_Curso VALUES (" + idCuenta + ", " + idCurso + ", null)");


        }
        private void PreviewCurso_Load(object sender, EventArgs e)
        {

        }

        private void bInscribirse_Click(object sender, EventArgs e)
        {
            InsertarCuentaEnCurso(user, curso);
            PantallaCurso ventana = new PantallaCurso(user, tipo, curso);



            this.Visible = false;
            ventana.ShowDialog();
        }
    }
}

