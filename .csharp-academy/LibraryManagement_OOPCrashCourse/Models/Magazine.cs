using Spectre.Console;

namespace LibraryManagementSystem_OOP.Models;

internal class Magazine : LibraryItem
{
    public string Publisher { get; set; }
    public DateTime PublishDate { get; set; }
    public int IssueNumber { get; set; }

    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNum) 
        : base(id, name, location)
    {
        Publisher = publisher;
        PublishDate = publishDate;
        IssueNumber = issueNum;
    }

    public override void DisplayDetails()
    {
        var panel = new Panel(new Markup($"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]") +
                         $"\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}" +
                         $"\n[bold]Issue Number:[/] {IssueNumber}" +
                         $"\n[bold]Location:[/] [blue]{Location}[/]")
        {
            Border = BoxBorder.Rounded
        };

        AnsiConsole.Write(panel);
    }


}

