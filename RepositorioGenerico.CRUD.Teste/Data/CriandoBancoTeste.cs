using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositorioGenerico.CRUD.Data.Context;
using RepositorioGenerico.CRUD.Model.Models;

namespace RepositorioGenerico.CRUD.Teste
{
    [TestClass]
    public class CriandoBancoTeste
    {
        [TestMethod]
        public void CriarBanco()
        {
            var context = new AmigosContext();

            var novoRegistro = new AmigosModel()
            {
                Nome = "Jean",
                Cpf = "234.334.343-66",
                Rg = "45.455.546-7",
                DataNascimento = DateTime.Now,
                Email = "jean.llopes@outlook.com",
                Telefone = "11 94949494"
            };

            context.Amigos.Add(novoRegistro);
            context.SaveChanges();
        }
    }
}
