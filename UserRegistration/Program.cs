namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FirstName("Pkr");
            user.LastName("Ram");
            user.Email("abc.xyz@bl.co.in");
            user.PhoneNumber("91 8825178849");
            user.Password("aes4bcd8");
        }
    }
}