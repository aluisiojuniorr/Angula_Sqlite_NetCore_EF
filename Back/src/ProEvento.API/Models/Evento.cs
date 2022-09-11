using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEvento.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public int DataEvento { get; set; }
        public int Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public int ImagemURL { get; set; }
    }
}
