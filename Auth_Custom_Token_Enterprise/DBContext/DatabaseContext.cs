using Auth_Custom_Token_Enterprise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Auth_Custom_Token_Enterprise.DBContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Auth_Custom_Token_Enterprise_Context")
        {

        }

        public DbSet<RegisterUser> RegisterUser { get; set; }
        public DbSet<RegisterCompany> RegisterCompany { get; set; }
        public DbSet<TokensManager> TokensManager { get; set; }
        public DbSet<ClientKey> ClientKey { get; set; }
        public DbSet<MusicStore> MusicStore { get; set; }
    }
}