namespace LoshkaDAL.Interfaces
{
    public interface IUnitOfWork
    {
        IUnitRepository UnitRepository { get; }
        // Добавить свойства для других репозиториев здесь
        int Complete();
        Task<int> CompleteAsync();
    }
}
