using System;
using System.Collections.Generic;

namespace BookManagement.DAL.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string Author { get; set; } = null!;

    public int BookCategoryId { get; set; }

    public virtual BookCategory BookCategory { get; set; } = null!;
    //biến object trỏ vào table category bên tay trái
    //class và table category(chứa cate id mà cuốn sách đó thuộc về)
    //                      genre type Description
    //                      biến này gọi là navigation Path
    //                      nhờ biến này giúp ta join 2 table category và book
    //                      đưa câu biến vào trong câu join khi sờ table List<Book> Books trong db context
}
