using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppModelo.Class;
using System.Diagnostics;

namespace AppModelo.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet(string nome)
        {
            Conexao conexao = new Conexao();
            bool resultado = conexao.TestarConexao();
            if (resultado == true)
            {
                Debug.WriteLine("CONEXAO REALIZADA COM SUCESSO");
                ViewData["conexao"] = "Conexao realizada com Sucesso!";
            }
            else
            {
                Debug.WriteLine("HOUVE UM ERRO AO RELIZAR A CONEXAO COM O BANCO DE DADOS");
                ViewData["conexao"] = "Houve um ERRO na conexao com o Banco de Dados!";
            }
        }
    }
}