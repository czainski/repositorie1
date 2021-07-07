using SelfHostWebApiBC.Context;
using System;

namespace SelfHostWebApiBC.Models
{
    public static class UnitOfWork
    {
        public static IRepository SQLServer(bool sqlServer) 
        {
            if (sqlServer)  return SQLEXPRESS();
            return Localdb();
        }
        public static IRepository Localdb()         => new Repository(new Db("localdb"));
        public static IRepository SQLEXPRESS() => new Repository(new Db("SQLEXPRESS"));
    }
}
