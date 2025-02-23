namespace Mission08_Roney.Models
{
    public interface IBaseballRepository
    {
        List<Manager> Managers { get; }
        
        public void AddManager(Manager manager);
    }
}