using HotChocolate.Caching;

namespace HotChocolateDemo.Types;

public class Query
{
    [CacheControl(10_000)]
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth."
        };

    public Book GetBookWithDefaultCacheControl() =>
        new Book
        {
            Title = "C# in depth."
        };
}
