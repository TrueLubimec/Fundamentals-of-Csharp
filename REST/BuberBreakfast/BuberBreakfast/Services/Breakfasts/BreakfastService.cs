using ErrorOr;
using ServiceError;

public class breakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfast = new();
    public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
    {
        _breakfast.Add(breakfast.Id, breakfast);

        return Result.Created;
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid id)
    {
        _breakfast.Remove(id);
        return Result.Deleted;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (_breakfast.TryGetValue(id, out var breakfast))
        {
            return _breakfast[id];
        }
        return Errors.Breakfast.NotFound;
    }

    public ErrorOr<Updated> UpsertBreakfast(Breakfast breakfast)
    {
        _breakfast[breakfast.Id] = breakfast;

        return Result.Updated;
    }
}