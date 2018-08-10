using Snacklager.Data;

namespace Snacklager.Logic.Contracts
{
    public interface ISnackRepository : IRepository<Snack>
    {
        Snack GetTopSnack();
    }
}
