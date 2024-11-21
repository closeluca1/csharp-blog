namespace Entities.Helpers;

public interface ISoftDelete
{
    DateTimeOffset? DeletedAt { get; set; }
}
