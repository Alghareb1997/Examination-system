 abstract class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }


    public abstract bool CheckId(int id);
  
}
