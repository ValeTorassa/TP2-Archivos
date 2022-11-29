using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivocCSharp
{
    public partial class Form1 : Form
    {

        GestorAlumnos alumnos = new GestorAlumnos();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LlenarGrilla();
        }

        private void cmdAlta_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno((long)this.numDNI.Value)
            {
               
                Raza = this.txtApellido.Text,
                Clase = this.txtNombre.Text
            };

            alumnos.Alta(alumno);
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = alumnos.Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                Alumno seleccionado = (Alumno)this.dataGridView1.SelectedRows[0].DataBoundItem;
                alumnos.Baja(seleccionado.ID);
                LlenarGrilla();
            }
          
        }

        private void txtApellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Enano")
            {
                lblFoto.ImageIndex = 3;
            }
            else if (txtApellido.Text == "Elfo")
            {
                lblFoto.ImageIndex = 1;
            }
            else if (txtApellido.Text == "Orco")
            {
                lblFoto.ImageIndex = 0;
            }
            else if (txtApellido.Text == "No Muerto")
            {
                lblFoto.ImageIndex = 4;
            }
            else
            {
                lblFoto.ImageIndex = 2;
            }
        }
    }
}
