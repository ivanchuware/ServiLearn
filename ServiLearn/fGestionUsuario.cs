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
    public partial class fGestionUsuario : Form
    {
        private Cuenta user;
        private int tipo;
        private int selectedUsuario = -1;
        List<object[]> tuplasUsuario;
        List<Tuple<int, int>> indiceIdUsuario;

        public fGestionUsuario()
        {
            InitializeComponent();
            consultarUsuarios();
            actualizarUsuarios();
        }

        private void consultarUsuarios()
        {
            try
            {
                MySQLDB miBD = new MySQLDB();
                tuplasUsuario = miBD.Select("SELECT * FROM Cuenta;");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void actualizarUsuarios()
        {
            lbUsuarios.Items.Clear();
            string filter = tbBuscadorUsuario.Text;
            indiceIdUsuario = new List<Tuple<int, int>>();
            int index = 0;
            foreach (object[] tupla in tuplasUsuario)
            {
                try
                {


                    string nombre = (string)tupla[1];
                    if (nombre.Contains(filter))
                    {

                        lbUsuarios.Items.Add(nombre);
                        indiceIdUsuario.Add(new Tuple<int, int>(index, (int)tupla[0]));
                        index++;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void tbBuscadorUsuario_TextChanged(object sender, EventArgs e)
        {
            actualizarUsuarios();
        }

        public void BorrarCuenta(int t)
        {
            String tipoidCuenta;
            String tipodelete;
            switch (t)
            {
                case 0:
                    tipoidCuenta = "id_Invitado";
                    tipodelete = "Invitado";
                    break;
                case 1:
                    tipoidCuenta = "id_Alumno";
                    tipodelete = "Alumno";
                    break;
                case 2:
                    tipoidCuenta = "id_Docente";
                    tipodelete = "Docente";
                    break;
                case 3:
                    tipoidCuenta = "id_Ong";
                    tipodelete = "Ong";
                    break;
                default:
                    tipoidCuenta = "id_Admin";
                    tipodelete = "Admin";
                    break;
            }
            MySQLDB miBD = new MySQLDB();
            miBD.Delete("DELETE FROM " + tipodelete + " where " + tipoidCuenta + " = " + user.id + ";");
            miBD.Delete("DELETE FROM Cuenta_Curso where id_Cuenta = " + user.id + ";");
            miBD.Delete("DELETE FROM Cuenta_Evento where id_Cuenta = " + user.id + ";");
            miBD.Delete("DELETE FROM Cuenta where id_Cuenta = " + user.id + ";");
            MessageBox.Show("Cuenta borrada con exito");
        }

        private int obtenerTipo(Cuenta c)
        {
            if (Invitado.esInvitado(user.id))
            {
                tipo = 0;
            }
            else if (Alumno.esAlumno(user.id))
            {
                tipo = 1;
            }
            else if (Docente.esDocente(user.id))
            {
                tipo = 2;
            }
            else if (ONG.esOng(user.id))
            {
                tipo = 3;
            }
            else
            {
                tipo = 4;
            }

            return tipo;
        }

        private void bEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                user = new Cuenta(selectedUsuario);
                tipo = obtenerTipo(user);
                BorrarCuenta(tipo);
                selectedUsuario = -1;
                actualizarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsuario = -1;
            foreach (Tuple<int, int> tupla in indiceIdUsuario)
            {

                if (lbUsuarios.SelectedIndex == tupla.Item1)
                {
                    selectedUsuario = tupla.Item2;
                }
            }
            
        }
    }
}
