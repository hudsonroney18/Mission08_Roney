namespace Mission08_Roney.Models;

public class EFBaseballRepository : IBaseballRepository
{
    private Lahman18712022Context _context;

    public EFBaseballRepository(Lahman18712022Context temp)
    {
        _context = temp;
    }
    public List<Manager> Managers => _context.Managers.ToList();

    public void AddManager(Manager manager)
    {
        _context.Add(manager);
        _context.SaveChanges();
    }
}