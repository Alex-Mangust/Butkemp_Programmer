class DataBase
{
    List<Department> dep_table = new();
    List<Worker> worker_table = new();

    public DataBase()
    {
        dep_table = new();
        worker_table = new();
    }
    public void appendWorker(Worker worker)
    {
        worker_table.Add(worker);
    }
    public void appendDep(Department dep)
    {
        dep_table.Add(dep);
    }
    public string selectAllDep()
    {
        string output = String.Empty;
        foreach (var item in dep_table)
        {
            output += $"{item.tittle}\n";
        }
        return output;
    }
    public string selectAllWorker()
    {
        string output = String.Empty;
        foreach (var i in worker_table)
        {
            output += $"{i.fullName} {i.age} {i.salary}\n";
        }
        return output;
    }
    public List<(string, int, string, int)> report()
    {
        List<(string, int, string, int)> rep = new();
        foreach (var i in worker_table)
        {
            rep.Add((i.fullName, i.age, dep_table[i.depId].tittle, i.salary));
        }
        return rep;
    }
}