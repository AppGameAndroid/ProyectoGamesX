using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoGamesX.Models
{
    class Videojuegos
    {
        [PrimaryKey, AutoIncrement]
        public int VJ_ID { get; set; }
        public string Titulos { get; set; }
        
        public byte [] ImagenVJs { get; set; }

        [MaxLength(500)]
        public string Sinopsiss { get; set; }
    }
}
