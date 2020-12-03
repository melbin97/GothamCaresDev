using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GothamCares.Entities;

namespace GothamCares.DAL.Contracts
{
    public interface IOutletDac
    {
        Task<List<Outlet>> GetAllOutlets();
    }
}
