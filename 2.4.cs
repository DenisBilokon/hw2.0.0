
class User
{
    public int age = 18;
    public string login = "Rollen", name = "Denis", surname = "Bilokon";
    private string date = "08.09.2022"; 

    public void Print ()
    {
        Console.WriteLine("age: " + age);
        Console.WriteLine("login: " + login);
        Console.WriteLine("name: " + name);   
        Console.WriteLine("surname: " + surname); 
        Console.WriteLine("date: " + date);   
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        User Den = new User ();
        Den.Print ();

    }

}