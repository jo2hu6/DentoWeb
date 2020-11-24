using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentoWebMVC.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Rotativa.AspNetCore;

namespace DentoWebMVC.Controllers
{
    public class BoletaController : Controller
    {

        public DentoWebContext cnx;
        public readonly IConfiguration configuration;
        public BoletaController(DentoWebContext cnx, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.cnx = cnx;
        }
        public IActionResult Index(int id)
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = cnx.Clientes.Where(o => o.usuario == claim.Value).FirstOrDefault();
            var historia = cnx.Historias.Include(o => o.cita).Where(o => o.idCita == id).FirstOrDefault();
            var paciente = cnx.Clientes.Where(o => o.idCliente == historia.cita.idCliente).FirstOrDefault();
            var doctor = cnx.Doctors.Where(o => o.idDoctor == historia.cita.idDoctor).FirstOrDefault();
            ViewBag.Doctor = doctor;
            ViewBag.Historia = historia;
            ViewBag.Paciente = paciente.nombres;
            ViewBag.Paciente1 ="si funca";

            return new ViewAsPdf("Index") { };
        }
    }
}
