using ProcessoSeletivoG7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ProcessoSeletivoG7.Controllers
{


    public class HomeController : Controller
    {

        public static List<string>lstFuncoes = new List<string>() {   
            "Funileiro",
            "Auto-Elétrico",
            "Troca de Óleo",
            "Borracheiro",
            "Concessionário",
            "Outro"};

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.list = lstFuncoes;
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContatoModel model)
        {

            if (ModelState.IsValid)
            {
                //Escreve o Arquivo no Meus Documentos
                string strCaminhoDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string strCaminhoCompleto = Path.Combine(strCaminhoDocs, "SaidaVictor.txt");
                using (StreamWriter outputFile = new StreamWriter(strCaminhoCompleto, true))
                {
                    outputFile.WriteLine("Nome: " + model.strNome);
                    outputFile.WriteLine("Telefone: " + model.strTelefone);
                    outputFile.WriteLine("Função: " + model.strFuncao);
                    outputFile.WriteLine("Email: " + model.strEmail);

                }
                ViewBag.conclusao = strCaminhoCompleto;
                return View("Conclusao");
            }


            ViewBag.list = lstFuncoes;
            return View();
        }
    }

}