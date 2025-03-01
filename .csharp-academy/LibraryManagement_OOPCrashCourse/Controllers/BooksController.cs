using LibraryManagementSystem_OOP.Models;
using Spectre.Console;

namespace LibraryManagementSystem_OOP.Controllers;

internal class BooksController : BaseController, IBaseController
{
    public void AddItem()
    {
        var title = AnsiConsole.Ask<string>("Enter the [green]title[/] of book that you want to add: ");
        var author = AnsiConsole.Ask<string>("Enter amount of [green]pages[/] that the book has: ");
        var category = AnsiConsole.Ask<string>("Enter a genre [](category)[/] of your book: ");
        var location = AnsiConsole.Ask<string>("Enter a [gray]location[/] of the library section: ");
        var pages = AnsiConsole.Ask<int>("Enter how many does the book contain [blue]PAGES[/] - ");

        if (MockDatabase.LibraryItems.OfType<Book>().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase))) //Lambda expression - easy way to tell the program to do a simple functions.
        {
           DisplayMessage("This book is already available.", "red");
        }
        else
        {
            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);

            MockDatabase.LibraryItems.Add(newBook);
            DisplayMessage("Your Book was added to our Library System!", "green");
        }

        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }

    public void ViewItems()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);

        table.AddColumn("[yellow]ID[/]");
        table.AddColumn("[yellow]Title[/]");
        table.AddColumn("[yellow]Author[/]");
        table.AddColumn("[yellow]Category[/]");
        table.AddColumn("[yellow]Location[/]");
        table.AddColumn("[yellow]Pages[/]");

        // Filtering only items of the book type
        var books = MockDatabase.LibraryItems.OfType<Book>();

        foreach (var book in books)
        {
            table.AddRow(
            book.Id.ToString(),
           $"[cyan]{book.Name}[/]",
           $"[cyan]{book.Author}[/]",
           $"[green]{book.Category}[/]",
           $"[blue]{book.Location}[/]",
           book.Pages.ToString()
            );
        };

        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine("Press any key to continue.");
        Console.ReadLine();
    }

    public void DeleteItem()
    {
        var books = MockDatabase.LibraryItems.OfType<Book>().ToList(); // List POUZE Knih z celé databaze.

        if (books.Count == 0)
        {
            DisplayMessage("There are no records that can be Deleted!", "red");
            Console.ReadKey();
            return;
        }

        var bookToDelete = AnsiConsole.Prompt(new SelectionPrompt<Book>()
                                                                         .Title("Select a [red]book[/] to delete:")
                                                                         .AddChoices(books));

        if (ConfirmDeletion(bookToDelete.Name))
        {
            if (MockDatabase.LibraryItems.Remove(bookToDelete))
            {
                DisplayMessage("Book deleted successfully!", "red");
            }
            else
            {
                DisplayMessage("Book not found.", "red");
            }
        }
        else
        {
            DisplayMessage("Deletion canceled.", "yellow");
        }

        DisplayMessage("Press Any Key to Continue.", "green");
        Console.ReadKey();
    }
}