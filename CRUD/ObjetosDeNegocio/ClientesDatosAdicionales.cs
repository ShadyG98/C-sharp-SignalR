//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObjetosDeNegocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientesDatosAdicionales
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
    
        public virtual Clientes Clientes { get; set; }
    }
}
