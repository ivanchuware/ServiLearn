﻿using BDLibrary;
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
    public partial class CreacionCurso : Form
    {
        String nombre;
        String desc;
        Cuenta user;
        int tipo;
        public CreacionCurso(Cuenta u, int t)
        {
            user = u;
            tipo = t;
            InitializeComponent();
        }

        public void InsertarCurso(string name, string desc, int owner)
        {
            MySQLDB miBD = new MySQLDB();
            try
            {
                miBD.Insert("INSERT INTO Curso VALUES (null, '" + owner + "', '" + name + "', '" + desc + "', null);");
                object[] tupla = miBD.Select("SELECT id_curso FROM Curso where id_owner = " + owner + " AND nombre = '" + name + "' and descripcion = '" + desc + "' ;")[0];
                int idcurso = (int)tupla[0];
                miBD.Insert("INSERT INTO Cuenta_Curso VALUES (" + owner + ", " + idcurso + ", null);");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            nombre = tbCurso.Text;
            desc = tbDescripcion.Text;
            if((nombre=="" || nombre== "Introduzca el Nombre del Curso")
                || (desc == "" || desc == "Introduzca una descripción del curso"))
            {
                if(nombre == "" || nombre == "Introduzca el Nombre del Curso")
                {
                    MessageBox.Show("Por favor añada un nombre al curso");
                }
                else
                {
                    MessageBox.Show("Por favor añada una descripción al curso");
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("", "¿Quiere crear este curso?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    InsertarCurso(nombre, desc, user.id);
                    MessageBox.Show("Curso Creado");
                    this.Visible = false;
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
