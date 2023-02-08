using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=ObligatorioSQLServerConnectionString")
        {

        }

        public DbSet<UsuarioEntity> UsuarioEntities { get; set; }

        public DbSet<PublicacionEntity> PublicacionEntities { get; set; }
    }
}
