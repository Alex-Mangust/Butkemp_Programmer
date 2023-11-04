class Department
{
    public int id;
    public string tittle;

    public Department(int id, string tittle)
    {
        this.id = id;
        this.tittle = tittle;
    }
    public override string ToString()
    {
        return $"tittle: {this.tittle} id: {this.id}";
    }
}