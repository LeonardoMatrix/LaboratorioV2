//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeloDados
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_laboratorio
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int qtdComputadores { get; set; }
        public int qtdAlunos { get; set; }
        public Nullable<bool> projetor { get; set; }
        public string software1 { get; set; }
        public string software2 { get; set; }
        public string software3 { get; set; }
        public string sistemaOperacional { get; set; }
    }
}