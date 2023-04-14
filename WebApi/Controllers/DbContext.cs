using Service.Data;

namespace WebApi.Controllers
{
    public static class DbContext
    {
        public static FizzFleetDbContext instance = new();
    }
}
