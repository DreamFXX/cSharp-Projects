using LibraryManagementSystem_OOP.Models;
using Spectre.Console;

namespace LibraryManagementSystem_OOP.Controllers;

internal abstract class BaseController
{
    protected void DisplayMessage(string message, string color = "yellow")
    {
        AnsiConsole.Markup($"[{color}]{message}[/]");
    }

    protected bool ConfirmDeletion(string itemName)
    {
        var confirm = AnsiConsole.Confirm($"Are you sure you want to delete [red]{itemName}[/]?");

        return confirm;
    }

}
