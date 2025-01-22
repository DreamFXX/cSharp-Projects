using CoffeeShop_EFCoreCrashCourse;
using Spectre.Console;

bool isRunning = true;

while (isRunning)
{
    AnsiConsole.Clear();

    var MenuRoute = AnsiConsole.Prompt(
    new SelectionPrompt<MainOptions>()
    .Title("[yellow]Welcome to the Coffee Shop Management![/]")
    .PageSize(10)
    .MoreChoicesText("[grey]For more options, use arrows on keyboard.[/]").AddChoices(
        MainOptions.AddProduct,
        MainOptions.DeleteProduct,
        MainOptions.UpdateProduct,
        MainOptions.ViewProductById,
        MainOptions.ViewAllProducts,
        MainOptions.Quit));

    switch (MenuRoute)
    {
        case MainOptions.AddProduct:
            ProductsController.AddProduct();
            break;
        case MainOptions.DeleteProduct:
            ProductsController.DeleteProduct();
            break;
        case MainOptions.UpdateProduct:
            ProductsController.UpdateProduct();
            break;
        case MainOptions.ViewProductById:
            ProductsController.ViewProductById();
            break;
        case MainOptions.ViewAllProducts:
            ProductsController.ViewAllProducts();
            break;
        case MainOptions.Quit:
            AnsiConsole.MarkupLine("[red]Goodbye![/]");
            isRunning = false;
            break;

    }
}

enum MainOptions
{
    AddProduct,
    DeleteProduct,
    UpdateProduct,
    ViewProductById,
    ViewAllProducts,
    Quit
}
