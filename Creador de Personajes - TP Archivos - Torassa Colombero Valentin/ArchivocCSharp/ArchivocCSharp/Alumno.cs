namespace ArchivocCSharp
{
    public class Alumno
    {

        public Alumno(long dni)
        {
            //creo un alumno, con el dni obligatoriamente
            this.ID = dni;
        }

        public Alumno(string linea)
        {
            //reconstruyo el objeto a partir de los datos levantados del archivo
            string[] datos = linea.Split(',');

            this.ID = long.Parse(datos[0]);
            this.Raza = datos[1];
            this.Clase = datos[2];

        }
        public long ID { get; private set; }
        public string Clase { get; set; }
        public string Raza { get; set; }


        public string GenerarRegistro()
        {
            //genero el registro de datos que guardaré en el archivo para poder reconstruir el objeto en unfuturo
            return $"{ID},{Raza},{Clase}";
        }
    }
}