
using Core.Entities;
using Core.Interface;
using Infrastructure.Data;

namespace API.Repository
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshToken
    {
        public RefreshTokenRepository(MainContext context) : base(context)
        {
        }
    }
}