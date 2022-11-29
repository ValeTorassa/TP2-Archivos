using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivocCSharp
{
   public class GestorAlumnos
    {

        string archivo = "alumnos.txt";

        public void Alta(Alumno unAlumno)
        {
            //abrmos el archivo
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                //obtengo el registro que guardaré en el archivo a partir del objeto recibido
                writer.WriteLine(unAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        public void Baja(long ID)
        {
            //para dar de baja, es necesario crear un nuevo set de datos sin el dato que estamos queriendo borrar
            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {

                string linea = reader.ReadLine();
                   
                while (linea != null)
                {


                    Alumno unAlumno = new Alumno(linea);
                  
                   if (unAlumno.ID != ID)
                    {
                        output += linea+ Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }


            }
            fs.Close();

             fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
              fs.Close();
        }
      

        public List<Alumno> Lista()
        {

            //creamos ua lista
            List<Alumno> lista = new List<Alumno>();

            //abrimos el archivo
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);


            //leeemos linea por línea y, por cada linea, creamos un objeto alumno que guardaremos en la lista
            using (StreamReader reader = new StreamReader(fs))
            {

                string linea = reader.ReadLine();
                while (linea != null)
                {


                    Alumno unAlumno = new Alumno(linea);

                    lista.Add(unAlumno);

                    linea = reader.ReadLine();
                }


            }
            //cerramos el arcivo
            fs.Close();

            return lista; 
        }
    }
}
