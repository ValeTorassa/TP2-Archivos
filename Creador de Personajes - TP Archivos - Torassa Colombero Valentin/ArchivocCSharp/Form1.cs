using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ArchivocCSharp
{
    public partial class Form1 : Form
    {

        GestorPersonajes pjs = new GestorPersonajes();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LlenarGrilla();
        }

        private void cmdAlta_Click(object sender, EventArgs e)
        {
            Personaje personajes = new Personaje((long)this.nmID.Value)
            {

                Raza = this.txtRaza.Text,
                Clase = this.txtClase.Text,
                Nombre = this.txtNombre.Text,
                Nivel = this.nmNivel.Text
            };

            pjs.Alta(personajes);
            LlenarGrilla();
            nmID.Text = "";
            txtRaza.Text = "";
            txtClase.Text = "";
            nmNivel.Text = "";
            txtNombre.Text = "";
            lblFoto.Image = null;
        }

        private void LlenarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = pjs.Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                Personaje seleccionado = (Personaje)this.dataGridView1.SelectedRows[0].DataBoundItem;
                pjs.Baja(seleccionado.ID);
                LlenarGrilla();
                nmID.Text = "";
                txtRaza.Text = "";
                txtClase.Text = "";
                nmNivel.Text = "";
                txtNombre.Text = "";
                lblFoto.Image = null;
            }
          
        }

        private void txtApellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtRaza.Text == "Enano")
            {
                lblFoto.ImageIndex = 3;
            }
            else if (txtRaza.Text == "Elfo")
            {
                lblFoto.ImageIndex = 1;
            }
            else if (txtRaza.Text == "Orco")
            {
                lblFoto.ImageIndex = 0;
            }
            else if (txtRaza.Text == "No Muerto")
            {
                lblFoto.ImageIndex = 4;
            }
            else
            {
                lblFoto.ImageIndex = 2;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nuevoId;
            string nuevaRaza;
            string nuevaClase;
            string nuevoNombre;
            string nuevoNivel;


            if (this.dataGridView1.SelectedRows.Count == 1)
            {
               nuevoId = nmID.Text;
               nuevaRaza = txtRaza.Text;
               nuevaClase = txtClase.Text;
               nuevoNombre = txtNombre.Text;
               nuevoNivel = nmNivel.Text;

                Personaje seleccionado = (Personaje)this.dataGridView1.SelectedRows[0].DataBoundItem;
                pjs.Modifica(seleccionado.ID, nuevoId, nuevaRaza, nuevaClase, nuevoNombre, nuevoNivel);

                LlenarGrilla();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int fila_seleccionada = dataGridView1.CurrentRow.Index;
                nmID.Text = dataGridView1.Rows[fila_seleccionada].Cells[0].Value.ToString();
                txtClase.Text = dataGridView1.Rows[fila_seleccionada].Cells[1].Value.ToString();
                txtRaza.Text = dataGridView1.Rows[fila_seleccionada].Cells[2].Value.ToString();
                txtNombre.Text = dataGridView1.Rows[fila_seleccionada].Cells[3].Value.ToString();
                nmNivel.Text = dataGridView1.Rows[fila_seleccionada].Cells[4].Value.ToString();
            }
        }
    }
}
