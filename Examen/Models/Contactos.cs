using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen.Models
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        [MaxLength(10)]
        public int Edad { get; set; }

        [MaxLength(100)]
        public string Pais { get; set; }

        [MaxLength(100)]
        public string Nota { get; set; }

        [MaxLength(100)]
        public string Latitud { get; set; }

        [MaxLength(100)]
        public string Longitud { get; set; }

    }
}
