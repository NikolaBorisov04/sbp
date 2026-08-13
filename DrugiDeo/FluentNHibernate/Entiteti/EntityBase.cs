namespace FluentNHibernateTemplate.Entiteti;

/// <summary>
/// Optional base class for entities that use a numeric primary key.
/// Delete this file if your database uses a different key strategy.
/// </summary>
public abstract class EntityBase
{
    public virtual int Id { get; protected set; }
}
