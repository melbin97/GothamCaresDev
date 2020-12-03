using GothamCares.Entities;
using GothamCares.DAL;
using System;
using GothamCares.DAL.Contracts;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GothamCares.BLL
{
  
    public class OutletBLL:IOutletBLL
    {
        private readonly IOutletDac dac;
        public OutletBLL(IOutletDac dac)
        {
            this.dac = dac;
        }

        public async Task<List<Outlet>> GetAllOutlets()
        {
            var outlets = await dac.GetAllOutlets();
            return outlets;
        }
    }
}
