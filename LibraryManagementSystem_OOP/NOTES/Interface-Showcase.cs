using static LibraryManagementSystem_OOP.NOTES.Interface_Showcase.IMammal;

namespace LibraryManagementSystem_OOP.NOTES;

internal class Interface_Showcase
{
    public interface IAnimal
    {
        string Name { get; }
        int Age { get; }

        void MakeSound();
    }

    public interface IMammal
    {
        bool HasFur { get; set; }

        void NurseYoung();

        public interface IPet
        {
            void Play();
        }
    }

    public class Dog : IAnimal, IMammal, IPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasFur { get; set; }

        public Dog(string name, int age, bool hasFur)
        {
            Name = name;
            Age = age;
            HasFur = hasFur;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }

        public void NurseYoung()
        {
            Console.WriteLine($"{Name} is nursing its puppies.");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing fetch.");
        }
    }
}

