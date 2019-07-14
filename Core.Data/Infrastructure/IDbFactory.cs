using App.Data.Entity;
using System;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        AppDbContext Init();
    }
}