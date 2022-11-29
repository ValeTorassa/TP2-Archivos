using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TpArchivos_TorassaValentin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //CARGAMOS LO QUE HAYA EN EL TXT
            string dni;
            string nombre;
            string apellido;
            int n;


            //abrimos el archivo
            FileStream fs = new FileStream("Registro.txt", FileMode.OpenOrCreate, FileAccess.Read);


            //leeemos linea por línea y, por cada linea, cargamos en el data grind view
            using (StreamReader reader = new StreamReader(fs))
            {

                string linea = reader.ReadLine();
                while (linea != null)
                {
                    //reconstruyo el objeto a partir de los datos levantados del archivo
                    string[] datos = linea.Split(',');

                    //Adicionamos nuevo renglon
                    n = dgvDatos.Rows.Add(); //aumenta una fila y regresa su indice


                    dni = datos[0];
                    nombre = datos[1];
                    apellido = datos[2];

                    //colocamos la informacion
                    dgvDatos.Rows[n].Cells[0].Value = dni; 
                                                                                                                                   

                    dgvDatos.Rows[n].Cells[1].Value = nombre;
                                                                    

                    dgvDatos.Rows[n].Cells[2].Value = apellido;
                                                                       

                    linea = reader.ReadLine();
                }


            }
            //cerramos el arcivo
            fs.Close();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n;

            //valido que ninguna cadena este vacia
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
            {
                lblError.Text = "Error: Uno o varios espacios estan vacios";

            }
            else
            {               

                //Adicionamos nuevo renglon
                n = dgvDatos.Rows.Add(); //aumenta una fila y regresa su indice

                //colocamos la informacion
                dgvDatos.Rows[n].Cells[0].Value = txtDNI.Text; //tomamos las filas de indice n
                                                                  //en la columna 0(monto)
                                                                  //e imprimimos en ella el contento de la textbox de monto

                dgvDatos.Rows[n].Cells[1].Value = txtNombre.Text;//lo mismo con tasa
                                                                //en la columna 1

                dgvDatos.Rows[n].Cells[2].Value = txtApellido.Text;//lo mismo con dias
                                                                   //en la columna 2

                lblError.Text = "";
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";

            }
        }


            private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvDatos.SelectedRows.Count == 1)
            {
                int fila_seleccionada = dgvDatos.CurrentRow.Index;
                dgvDatos.Rows[fila_seleccionada].Cells[0].Value = txtDNI.Text;
                dgvDatos.Rows[fila_seleccionada].Cells[1].Value = txtNombre.Text;
                dgvDatos.Rows[fila_seleccionada].Cells[2].Value = txtApellido.Text;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow.Index > -1)
            {
                dgvDatos.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //abrmos el archivo
            FileStream fs = new FileStream("Registro.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    writer.WriteLine($"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}");
                }
            }
            fs.Close();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDatos.SelectedRows.Count == 1)
            {
                int fila_seleccionada = dgvDatos.CurrentRow.Index;
                txtDNI.Text = dgvDatos.Rows[fila_seleccionada].Cells[0].Value.ToString();
                txtNombre.Text = dgvDatos.Rows[fila_seleccionada].Cells[1].Value.ToString();
                txtApellido.Text = dgvDatos.Rows[fila_seleccionada].Cells[2].Value.ToString();
            }

        }
    }
}
