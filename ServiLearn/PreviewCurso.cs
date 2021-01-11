using BDLibrary;
using System;
using System.Windows.Forms;

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



            if (tipo == 0)
            {
                bInscribirse.Visible = false;
            }

            lCurso.Text = ("Curso: " + c.Nombre);
            tbDesc.Text = c.Descripcion;
        }
        private void InsertarCuentaEnCurso(Cuenta cuenta, Curso curso)
        {
            MySQLDB miBD = new MySQLDB();

            int idCuenta = cuenta.id;
            int idCurso = curso.Id;

            miBD.Insert("INSERT INTO Cuenta_Curso VALUES (" + idCuenta + ", " + idCurso + ")");


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

