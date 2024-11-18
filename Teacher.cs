class Teacher : User
{
    public string Subject { get; set; }
    public static List<Teacher> Teachers = new List<Teacher>();

    public override bool CheckId(int id)
    {
        
        foreach (var item in Teachers)
        {
            if (item.Id == id)
            {
                Console.WriteLine(" Sorry this ID is already exist  ");
                return true;

            }

        }
        return false;
    }
}


