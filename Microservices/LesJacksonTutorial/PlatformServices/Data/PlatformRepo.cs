using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Data;
public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext dbContext;

    public PlatformRepo(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void CreatePlatform(Platform platform)
    {
        throw new NotImplementedException();
    }

    public Platform GetPlatform(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Platform> GetPlatforms()
    {
        throw new NotImplementedException();
    }

    public bool SaveChanges()
    {
        throw new NotImplementedException();
    }
}
