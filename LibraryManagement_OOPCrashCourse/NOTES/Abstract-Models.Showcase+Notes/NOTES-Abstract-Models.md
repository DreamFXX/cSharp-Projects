- The class Animal is declared as abstract, which means it cannot be instantiated directly. Instead, it serves as a blueprint for other classes that will inherit from it.

- An abstract class can contain both abstract methods (without implementation) and concrete methods (with implementation).

- Inheritance in object-oriented programming (OOP) allows one class to inherit the properties and methods of another class, facilitating code reusability and establishing a hierarchical relationship. Let's see it in practice. Showcase in Program.cs -> Class Dog : Animal :)

- My library app needed to support not only books but also magazines and newspapers. Since these entities will have common as well as unique characteristics, it's a perfect use case for inheritance. -> Folder called Models, there is a file -> **LibraryItem.cs** -> abstract class in use.