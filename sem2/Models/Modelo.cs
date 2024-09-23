﻿using System.ComponentModel;

namespace sem2.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        [DisplayName("Marca")]
        public Fabricante? Fabricante {  get; set; }
        public int FabricanteId { get; set; }
    }
}
