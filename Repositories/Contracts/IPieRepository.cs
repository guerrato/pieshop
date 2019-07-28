using System;
using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.Repositories
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAll();
        Pie GetById(int id);
    }
}
