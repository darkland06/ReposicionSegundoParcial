﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
        
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Rol { get; set; }
        public bool EstaActivo { get; set; }
        public string Constraseña { get;set }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string correo, DateTime fechaCreacion, string rol, bool estaActivo, string constraseña)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            Rol = rol;
            EstaActivo = estaActivo;
            Constraseña = constraseña;
        }
    }
}
