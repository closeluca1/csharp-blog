using Entities.Helpers;

public class BaseEntity : WithTimeStamp
{
    public Guid Id { get; set; }
}