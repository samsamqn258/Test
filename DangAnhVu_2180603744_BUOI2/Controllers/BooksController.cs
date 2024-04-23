using DangAnhVu_2180603744_BUOI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DangAnhVu_2180603744_BUOI2.Controllers
{
    public class BooksController : Controller
    {
        //khai bao list book
        private List<Book> listBooks;
        public BooksController()
        {
            listBooks = new List<Book>();

            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Đi tìm lẽ sống",
                Author = "Không biết",
                PublicYear = 2000,
                Price = 50000,
                Cover="Content/image/book1.jpg"
            });


            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "7 thói quen hiệu quả",
                Author = "Không biết",
                PublicYear = 2000,
                Price = 60000,
                Cover = "Content/image/book2.jpg"
            });


            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Hạt giống tâm hồn",
                Author = "Không biết",
                PublicYear = 2000,
                Price =70000,
                Cover = "Content/image/book3.jpg"
            });


            listBooks.Add(new Book()
            {
                Id = 4,
                Title = "Từ thất bại đến thành công",
                Author = "Không biết",
                PublicYear = 2011,
                Price = 80000,
                Cover = "Content/image/book4.jpg"
            });
            //sửa sadfasadsfaaaaaaaaadfasfasfsadsfafafasfadsfa
            listBooks.Add(new Book()
            {
                Id = 8,
                Title = "Từ thất bại đến thành công",
                Author = "Không biết",
                PublicYear = 2011,
                Price = 80000,
                Cover = "Content/image/book4.jpg"
            });

            listBooks.Add(new Book()
            {
                Id = 5,
                Title = "Từ thất bại đến thành công",
                Author = "Không biết",
                PublicYear = 2011,
                Price = 80000,
                Cover = "Content/image/book4.jpg"
            });

        }
        // GET: Book
        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "HUTECH BOOKS";
            return View(listBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Book book = listBooks.Find(s => s.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //Bước 1. Hiển thị thông tin quyển sách cần edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(x => x.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        //Bước 2. Edit quyển sách đã tìm thấy
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)//nếu dữ liệu nhập đúng theo yêu cầu
            {
                try
                {
                    var editBook = listBooks.Find(b => b.Id == book.Id);
                    editBook.Title = book.Title;
                    editBook.Author = book.Author;
                    editBook.Cover = book.Cover;
                    editBook.Price = book.Price;
                    editBook.PublicYear = book.PublicYear;
                    return View("ListBooks", listBooks);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else//dữ liệu người dùng edit không hợp lệ
            {
                ModelState.AddModelError("", "Input Model Not Valide!");
                return View(book);

            }
        }
    }
}