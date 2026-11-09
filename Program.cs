using Assignment_01_EF_Core.ReadMoreBooks.Data;

namespace Assignment_01_EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BookstoreDbContext context = new BookstoreDbContext())
            {
                bool isCreated = context.Database.EnsureCreated();

                if (isCreated)
                {
                    Console.WriteLine("Database Created Successfully!");
                }
                else
                {
                    Console.WriteLine("Database Already Exists!");
                }
            }
        }
    }
}
