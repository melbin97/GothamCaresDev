using GothamCares.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GothamCares.BLL
{
    public interface IOutletBLL
    {
        Task<List<Outlet>> GetAllOutlets();
    }
}
