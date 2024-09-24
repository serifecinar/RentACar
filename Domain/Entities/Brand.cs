using Core.Persistance.Repository;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }
}
