namespace Projet_RMS_Final.Dao
{
    public interface IDao<T>
    {
        void Create(T entity);
        T Read(int id);
        List<T> List();
        void Update(T entity);
        void Delete(int id);
    }

}
