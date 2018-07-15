using LibrosBiblicos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrosBiblicos.UI.Registro
{
    public partial class rLibros : Form
    {
        public rLibros()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(DescripcionrichTextBox.Text))
            {
                errorProvider1.SetError(DescripcionrichTextBox, "llena el campo de descripcion");
                return false;
            }
            if (string.IsNullOrEmpty(SiglastextBox.Text))
            {
                errorProvider1.SetError(SiglastextBox, "llena el campo de siglas");
                return false;
            }
            if (string.IsNullOrEmpty(TipotextBox.Text))
            {
                errorProvider1.SetError(TipotextBox, "llenar el campo de tipo");
                return false;
            }

            return true;
        }

        private Libros LLenaClase()
        {
            Libros Libro = new Libros();
            Libro.LibroId = Convert.ToInt32(LibroIdnumericUpDown.Value);
            Libro.Fecha = FechadateTimePicker.Value;
            Libro.Descripcion = DescripcionrichTextBox.Text;
            Libro.Siglas = SiglastextBox.Text;
            Libro.Tipo = TipotextBox.Text;

            return Libro;
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LibroIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            DescripcionrichTextBox.Clear();
            SiglastextBox.Clear();
            TipotextBox.Clear();
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (!Validar())
            {
                MessageBox.Show("llena", "trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Libros Libro = LLenaClase();
                bool paso = false;

                if (LibroIdnumericUpDown.Value == 0)
                {
                    paso = BLL.LibrosBLL.Guardar(Libro);
                }
                else
                {
                    paso = BLL.LibrosBLL.Modificar(Libro);
                }

                if (paso)
                {
                    MessageBox.Show("guardado", "acceptado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIdnumericUpDown.Value);
            if (BLL.LibrosBLL.Eliminar(id))

            {
                MessageBox.Show("eliminado", "exitosamente",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                LibroIdnumericUpDown.Value = 0;
                FechadateTimePicker.Value = DateTime.Now;
                DescripcionrichTextBox.Clear();
                SiglastextBox.Clear();
                TipotextBox.Clear();
            }
            else
            {
                MessageBox.Show("no fueeliminado", "trate de nuevo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIdnumericUpDown.Value);
            Libros Libro = BLL.LibrosBLL.Buscar(id);

            if (Libro != null)
            {
                FechadateTimePicker.Value = Libro.Fecha;
                DescripcionrichTextBox.Text = Libro.Descripcion;
                SiglastextBox.Text = Libro.Siglas;
                TipotextBox.Text = Libro.Tipo;
            }
            else
            {
                MessageBox.Show("no encontro", "buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
