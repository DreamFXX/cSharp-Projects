using Spectre.Console;
using LibraryManagementSystem_OOP.Models;

namespace LibraryManagementSystem_OOP.Controllers;

public interface IBaseController
{
    // We are using C# Inheritance - dědění rodičovské třídy (BookController.cs).
    void ViewItems();
    void AddItem();
    void DeleteItem();
}


