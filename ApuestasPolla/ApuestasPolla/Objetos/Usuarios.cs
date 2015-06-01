using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApuestasPolla.Objetos
{
    public class Usuario
    {

        public Int32 Id { get; set; }

        public String Nombre { get; set; }

        public String Contraseña { get; set; }

        public String Sexo { get; set; }

        public String Ciudad { get; set; }

        public String Telefono { get; set; }
    }
}