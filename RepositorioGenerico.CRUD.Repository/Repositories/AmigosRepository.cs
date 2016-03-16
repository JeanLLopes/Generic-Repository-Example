using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioGenerico.CRUD.Repository.Base;
using RepositorioGenerico.CRUD.Model.Models;
using RepositorioGenerico.CRUD.Data.Context;

namespace RepositorioGenerico.CRUD.Repository.Repositories
{
    public sealed class AmigosRepository : BaseRepository<AmigosModel>
    {
        public AmigosRepository(): base(new AmigosContext())
        {
            
        }
    }
}
