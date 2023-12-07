using Domain.Base;
using System;


namespace Domain.Entities
{
    public class Usuarios : Entity
    {           
        public string? Cpf { get; set; }
        public string? ReturnMsg { get; set; }       
        
    }
}