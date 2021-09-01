using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parteIII.Models;

namespace parteIII.Controllers
{
    public class CandidatoController : Controller
    {

        public IactionResult Trabalhe()
        {
            return View();
        }
        [HttpPost]
        public IactionResult Trabalhe(Candidato cadastroCandidato)
        {
            var candidato = new CandidatoRepository();
            candidato.Cadastro(cadastroCandidato);
            ViewBag.Mensagem = "Curriculo Cadastrado com sucesso!!!";
            return View();
        }
    }
}