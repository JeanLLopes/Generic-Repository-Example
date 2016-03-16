using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioGenerico.CRUD.Data.Entities;
using RepositorioGenerico.CRUD.Model.Models;

namespace RepositorioGenerico.CRUD.Data.Context
{
    public class AmigosContext : DbContext
    {
        public AmigosContext()
            : base(ConfigurationManager.ConnectionStrings["AmigosConnectionString"].ConnectionString)
        {
            
        }

        public DbSet<AmigosModel> Amigos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AmigosContext>());

            //passsamos as configurações da tabela
            modelBuilder.Configurations.Add(new AmigosEntities());
        }
    }
}
