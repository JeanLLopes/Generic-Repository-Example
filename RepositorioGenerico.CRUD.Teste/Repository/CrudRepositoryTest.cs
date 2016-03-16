using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositorioGenerico.CRUD.Repository.Repositories;
using RepositorioGenerico.CRUD.Model.Models;

namespace RepositorioGenerico.CRUD.Teste.Repository
{
    [TestClass]
    public class CrudRepositoryTest
    {
        private readonly AmigosRepository repository = new AmigosRepository();

        [TestMethod]
        public void Cadastrar()
        {
            var novoRegistro = new AmigosModel()
            {
                Nome="Jose Testando",
                Cpf="234.234.234-09",
                Rg="23.234.234.234-9",
                Telefone="2345-2344",
                DataNascimento=DateTime.Now,
                Email="jlopes@outlook.com"
            };

            repository.Add(novoRegistro);
        }


        [TestMethod]
        public void Atualizar()
        {
            var dados = repository.Find(1);
            dados.Nome = String.Format("{0} {1}", dados.Nome, "ALTERADO");
            repository.Update(dados);
        }



        [TestMethod]
        public void Deletar()
        {
            repository.Delete(repository.Find(1));   
        }

        [TestMethod]
        public void ListaRegistros()
        {
            var resultado = repository.GetAll();
        }


        [TestMethod]
        public void ListaComFiltros()
        {
            var resultado = repository.GetAll(x => x.Nome.Contains("a"));
        }
    }
}
