

using Microsoft.EntityFrameworkCore;

public class Seed
{

    public static void Initial(IServiceProvider serviceProvider)
    {
        using (var context = new BookContext(serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
        {
            if (context.Book.Any())
            {
                return;
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "The Linux Kenel Book",
                    Author = "Linus Torvald",
                    Price = 19.99m,
                    Genre = "Programming",
                    ReleaseDate = new DateTime(2016, 4, 1)

                },
                new Book
                {
                    Title = "The Java Book",
                    Author = "Jane Doe",
                    Price = 29.99m,
                    Genre = "Programming",
                    ReleaseDate = new DateTime(2003, 2, 12)
                },
                new Book
                {
                    Title = "The Python Book",
                    Author = "John Doe",
                    Price = 39.99m,
                    Genre = "Programming",
                    ReleaseDate = new DateTime(1998, 12, 25)
                },
                new Book
                {
                    Title = "The Ruby Book",
                    Author = "Jane Smith",
                    Price = 49.99m,
                    Genre = "Programming",
                    ReleaseDate = new DateTime(1999, 10, 30)
                },
                new Book
                {
                    Title = "The C++ Book",
                    Author = "Bjarne Stroustrup",
                    Price = 59.99m,
                    Genre = "Programming",
                    ReleaseDate = new DateTime(2008, 8, 13)
                },
                new Book
                {
                    Title = "The C# Book",
                    Author = "Jeff T. Fritz",
                    Price = 69.99m,
                    Genre = "Programming",
                    ReleaseDate = new DateTime(2011, 12, 3)
                }
                            );
            context.SaveChanges();
        }

    }

}