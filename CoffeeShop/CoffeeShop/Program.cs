using CoffeeShop;
using Microsoft.Extensions.Configuration;

UserInterface userInterface = new UserInterface();
userInterface.MainMenu();

static void MainMenu(string[] args)
{
    IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath("C:/Users/marti/_cSharpProjects/CoffeeShop/CoffeeShop")
        .AddJsonFile("appsettings.json")
        .Build();

    string _connectionString = configuration.GetConnectionString("DefaultConnection");
    if (_connectionString == null)
        throw new InvalidOperationException("Connection string not found in appsettings.json");

    UserInterface.MainMenu(_connectionString);
}

enum MenuOptions
{
    CreateProduct,
    ReadProduct,
    UpdateProduct,
    DeleteProduct,
    ShowAllProducts,
    ShowProductsByCategory,
    Exit,
}
