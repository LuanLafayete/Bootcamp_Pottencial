/*
Qual é o comando que faz para gerar um novo console
    dotnet new console

Qual é o comando que inicia uma WEB API no Visual Code:
    dotnet new webapi

Qual é o comando que para compilar sem pausar
    dotnet watch run

INSTALAÇÕES QUE PRECISAM SER REALIZADAS
    dotnet add package Microsoft.EntityFrameworkCore.Design

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }  

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }
    }
}