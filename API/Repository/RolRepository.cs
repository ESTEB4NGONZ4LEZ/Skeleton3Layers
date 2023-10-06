
using Core.Entities;
using Core.Interface;
using Infrastructure.Data;

namespace API.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        public RolRepository(MainContext context) : base(context)
        {
        }
    }
}