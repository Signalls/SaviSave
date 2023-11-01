using Savi.Data.Domains;

namespace Savi.Data.IRepositories
{
    public interface IGetUser
    {
        public Task<ApplicationUser> GetUserById(string Id);

    }
}
