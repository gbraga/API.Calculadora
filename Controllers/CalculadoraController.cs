using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Calculardora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Calculardora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost]
        [Route("somar")]
        public double Somar(Operacao op) => op.valor1 + op.valor2;

        [HttpPost]
        [Route("subtrair")]
        public double Subtrair(Operacao op) => op.valor1 - op.valor2;

        [HttpPost]
        [Route("multiplicar")]
        public double Multiplicar(Operacao op) => op.valor1 * op.valor2;

        [HttpPost]
        [Route("dividir")]
        public double Dividir(Operacao op) => op.valor1 / op.valor2;
    }
}
