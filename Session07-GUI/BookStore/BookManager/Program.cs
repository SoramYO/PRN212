using BookManager.Entities;

namespace BookManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //thêm 1 cuốn sách rồi in ra
            BookStoreContext context = new();
            context.Books.Add(new Book
            {
                BookId = 21,
                BookName = "Conan",
                Author = "Hoang",
                Description = "Truyen tranh",
                PublicationDate = DateTime.Now,
                BookCategoryId = 1
            });
            context.SaveChanges();

            //in ra tất cả các cuống sách

            //context là cơ sở dữ liệu BookStore mà ta muốn giao tiếp với nó
            //chính là thừng chứa chưa 1 list book và 1 list bookCategory
            //crud trên book thì ta gọi List<Book> này

            //Cabinet:
            //List<Book> _arr

            //Context
            //DbSet<Book> Books
            //.Books là ta chạm list book
            //.Add


            //select * from Book
            List<Book> arr = context.Books.ToList();
            Console.WriteLine("The list of book");
            foreach (var item in arr)
            {
                Console.WriteLine(item.BookId + "|" + item.BookName);
            }
        }
    }
}

//dotnet ef dbcontext scaffold "Server=(local);Database= BookStore;UID=sa;PWD=12345;TrustServerCertificate=True" "Microsoft.EntityFrameworkCore.SqlServer" --output-dir "Entities" --context-dir ".\"