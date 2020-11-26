﻿using DentoWebMVC.Models.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DentoWebMVC.Models.DentoWeb
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string codigo { get; set; }


        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener minimo 3 caracteres.")]
        [DisplayName("Nombre")]
        public string nombres { get; set; }


        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido debe tener por lo menos 3 caracteres.")]
        [DisplayName("Apellidos")]
        public string apellidos { get; set; }


        //[Required(ErrorMessage = "El dni es requerido...")]
        //[RegularExpression(@"\d(8)", ErrorMessage = "Debe contener 8 digitos")]
        [DisplayName("DNI")]
        public string dni { get; set; }


        [Required(ErrorMessage = "Este campo es requerido.")]
        [DataType(DataType.Date, ErrorMessage = ("Fecha de nacimiento no válida."))]
        [DisplayName("Fecha Nacimiento")]
        public DateTime fechaNac { get; set; }



        [Required(ErrorMessage = "Este campo es requerido.")]
        [EmailAddress(ErrorMessage = "Email no válido.")]
        [DisplayName("Correo Electronico")]
        public string correo { get; set; }


        // [Required(ErrorMessage = "El telefono es requerido...")]
        //[StringLength(20, MinimumLength = 9, ErrorMessage = "El telefono debe tener por lo menos 9 digitos.")]
        [DisplayName("Telefono")]
        public string telefono { get; set; }


        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El usuario debe tener por lo menos 4 caracteres.")]
        [DisplayName("Usuario")]
        public string usuario { get; set; }


        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "La contraseña debe tener por lo menos 3 caracteres.")]
        [DisplayName("Contraseña")]
        public string passwd { get; set; }

        public List<Cita> Citas { get; set; }
    }

}
