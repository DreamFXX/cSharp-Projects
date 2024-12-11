using Spectre.Console;
using LibraryManagementSystem_OOP.Models;

namespace LibraryManagementSystem_OOP.Controllers;

internal class MagazineController : IBaseController
{
    public void ViewItems()
    {
        var table = new Table();

        table.Border(TableBorder.Rounded);
        table.AddColumn("[yellow]ID[/]");
        table.AddColumn("[yellow]Title[/]");
        table.AddColumn("[yellow]Publisher[/]");
        table.AddColumn("[yellow]Publish Date[/]");
        table.AddColumn("[yellow]Issue Number[/]");
        table.AddColumn("[yellow]Location[/]");

        var magazines = MockDatabase.LibraryItems.OfType<Magazine>();

        foreach (var magazine in magazines)
        {
            table.AddRow(
                       magazine.Id.ToString(),
                       $"[cyan]{magazine.Name}[/]",
                       $"[cyan]{magazine.Publisher}[/]",
                       $"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]",
                       magazine.IssueNumber.ToString(),
                       $"[blue]{magazine.Location}[/]"
           );
        }

        AnsiConsole.Write(table);
        AnsiConsole.Markup("Press any Key to continue.");
        Console.ReadKey();
    }

    public void AddItem()
    {
        var title = AnsiConsole.Ask<string>($"Enter the title of [yellow]Magazine[/] you want to Add: ");
        var publisher = AnsiConsole.Ask<string>($"Who published submitted [yellow]Magazine[/]? -> ");
        var publishDate = AnsiConsole.Ask<DateTime>("Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):");
        var location = AnsiConsole.Ask<string>("Enter the [green]location[/] of the magazine:");
        var issueNumber = AnsiConsole.Ask<int>("Enter the [green]issue number[/] of the magazine:");

        if (MockDatabase.LibraryItems.OfType<Magazine>().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))
        {
            AnsiConsole.MarkupLine("[red]This magazine already exists.[/]");
        }
        else
        {
            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);
            MockDatabase.LibraryItems.Add(newMagazine);
            AnsiConsole.MarkupLine("[green]Magazine added successfully![/]");
        }

        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }

    public void DeleteItem()
    {
        if (MockDatabase.LibraryItems.OfType<Magazine>().Count() == 0)
        {
            AnsiConsole.MarkupLine("[red]There are no magazines available to delete.[/]");
            Console.ReadKey();
            return;
        }

        var magazineToDelete = AnsiConsole.Prompt(
            new SelectionPrompt<Magazine>()
                .Title("Select a [red]magazine[/] to delete:")
                .UseConverter(m => $"{m.Name} (Issue {m.IssueNumber})")
                .AddChoices(MockDatabase.LibraryItems.OfType<Magazine>()));

        if (MockDatabase.LibraryItems.Remove(magazineToDelete))
        {
            AnsiConsole.MarkupLine("[red]Magazine deleted successfully![/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Magazine not found.[/]");
        }

        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }
}

