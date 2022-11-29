using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivocCSharp
{
   public class GestorPersonajes
    {

        string archivo = "Personajes.txt";

        public void Alta(Personaje unPersonaje)
        {
            //abrmos el archivo
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                //obtengo el registro que guardaré en el archivo a partir del objeto recibido
                writer.WriteLine(unPersonaje.GenerarRegistro());
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


                    Personaje unPersonaje = new Personaje(linea);
                  
                   if (unPersonaje.ID != ID)
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
      

        
        public void Modifica(long ID,string nuevoId,string nuevaRaza,string nuevaClase, string nuevoNombre, string nuevoNivel)
        {


            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {

                string linea = reader.ReadLine();

                while (linea != null)
                {


                    Personaje unPersonaje = new Personaje(linea);

                    if (unPersonaje.ID != ID)
                    {
                        output += linea + Environment.NewLine;
                    }
                    else
                    {
                        string str;
                        string[] datos = linea.Split(',');

                        datos[0] = nuevoId;
                        datos[1] = nuevaRaza;
                        datos[2] = nuevaClase;
                        datos[3] = nuevoNombre;
                        datos[4] = nuevoNivel;

                        str = $"{datos[0]}, {datos[1]}, {datos[2]}, {datos[3]}, {datos[4]}";

                        output += str + Environment.NewLine;


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
        

        public List<Personaje> Lista()
        {

            //creamos ua lista
            List<Personaje> lista = new List<Personaje>();

            //abrimos el archivo
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);


            //leeemos linea por línea y, por cada linea, creamos un objeto alumno que guardaremos en la lista
            using (StreamReader reader = new StreamReader(fs))
            {

                string linea = reader.ReadLine();
                while (linea != null)
                {


                    Personaje unPersonaje = new Personaje(linea);

                    lista.Add(unPersonaje);

                    linea = reader.ReadLine();
                }


            }
            //cerramos el arcivo
            fs.Close();

            return lista; 
        }
    }
}
