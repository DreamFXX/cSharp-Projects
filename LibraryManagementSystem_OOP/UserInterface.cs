using LibraryManagementSystem_OOP.Controllers;
using Spectre.Console;
using static LibraryManagementSystem_OOP.Enums;

namespace LibraryManagementSystem_OOP; // same as {}, cleaner write.

internal class UserInterface
{
    private readonly BooksController _booksController = new();
    private readonly MagazineController _magazinesController = new();
    private readonly NewspaperController _newspapersController = new();

    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            var actionChoice = AnsiConsole.Prompt(
                     new SelectionPrompt<MenuAction>()
                    .Title("Library management - Pick an action from MENU below.")
                    .AddChoices(Enum.GetValues<MenuAction>()));

            var itemTypeChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<ItemType>()
                    .Title("Select the type of item:")
                    .AddChoices(Enum.GetValues<ItemType>())
                );
        

            switch (actionChoice)
            {
                case MenuAction.ViewItem:
                    ViewItems(itemTypeChoice);
                    break;
                case MenuAction.AddItem:
                    AddItem(itemTypeChoice);
                    break;
                case MenuAction.DeleteItem:
                    DeleteItem(itemTypeChoice);
                    break;

            }
        }
    }

    private void ViewItems(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Book:
                _booksController.ViewItems();
                break;
            case ItemType.Magazine:
                _magazinesController.ViewItems();
                break;
            case ItemType.Newspaper:
                _newspapersController.ViewItems();
                break;
        }
    }

    private void AddItem(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Book:
                _booksController.AddItem();
                break;
            case ItemType.Magazine:
                _magazinesController.AddItem();
                break;
            case ItemType.Newspaper:
                _newspapersController.AddItem();
                break;
        }
    }

    private void DeleteItem(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Book:
                _booksController.DeleteItem();
                break;
            case ItemType.Magazine:
                _magazinesController.DeleteItem();
                break;
            case ItemType.Newspaper:
                _newspapersController.DeleteItem();
                break;
        }
    }
}

