using Spectre.Console;

namespace LibraryManagementSystem_OOP.Models;

internal class Book : LibraryItem
{
    //Three fields that are unique to Book.
    internal string Author { get; set; }
    internal string Category { get; set; }
    internal int Pages { get; set; }

    internal Book(int id, string name, string location, string author, string category, int pages)
        : base(id, name, location)
    {
        Author = author;
        Category = category;
        Pages = pages;
    }

    public override void DisplayDetails()
    {
        var panel = new Panel(new Markup($"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]") +
                                         $"\n[bold]Pages:[/] {Pages}" +
                                         $"\n[bold]Category:[/] [green]{Category}[/]" +
                                        ($"\n[bold]Location:[/] [blue]{Location}[/]"))
        {
            Border = BoxBorder.Rounded
        };

        AnsiConsole.Write(panel);

    }
}

