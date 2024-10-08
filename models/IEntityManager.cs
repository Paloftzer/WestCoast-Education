namespace WestCoast_Education.models;

public interface IEntityManager<T>
{
    void AddEntity(T entity);
    List<T> ListEntities();
}
