class Worker
{
    public int id;
    public int depId;
    public int age;
    public string fullName;
    public int salary;

    public Worker(int id, int depId, string fullName, int age, int salary)
    {
        this.id = id;
        this.depId = depId;
        this.fullName = fullName;
        this.age = age;
        this.salary = salary;
    }
    public override string ToString()
    {
        return $"id: {this.id} depID: {this.depId} FullName: {this.fullName} age: {this.age} salary: {this.salary}";
    }
}