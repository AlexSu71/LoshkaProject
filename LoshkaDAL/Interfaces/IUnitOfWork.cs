namespace LoshkaDAL.Interfaces
{
    public interface IUnitOfWork
    {
        IUnitRepository UnitRepository { get; }
    
        int Complete();
        Task<int> CompleteAsync();
    }
}
