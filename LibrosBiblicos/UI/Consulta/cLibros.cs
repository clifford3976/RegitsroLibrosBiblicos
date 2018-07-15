using LibrosBiblicos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace LibrosBiblicos.UI.Consulta
{
    public partial class cLibros : Form
    {
        public cLibros()
        {
            InitializeComponent();
        }

        private void cLibros_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Libros, bool>> Filtro = x => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: //id
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    Filtro = x => x.LibroId == id;
                    break;

                case 1: //Fecha
                    Filtro = x => x.Fecha.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 2: //Descripcion
                    Filtro = x => x.Descripcion.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 3://todo
                    ConsultasdataGridView.DataSource = BLL.LibrosBLL.GetList(Filtro);
                    break;
                case 4: //Siglas
                    Filtro = x => x.Siglas.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

                case 5: //Tipo
                    Filtro = x => x.Tipo.Equals(CriteriotextBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;

            }
        }
    }
}
