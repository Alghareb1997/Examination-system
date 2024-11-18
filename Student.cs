class Student : User
{
    
    public static List<Student> Students = new List<Student>();
    
    public  override bool CheckId(int id)
    {
        foreach (var item in Students)
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
