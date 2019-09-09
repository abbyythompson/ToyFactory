using ToyFactoryLibrary.Enums;
using ToyFactoryLibrary.Interfaces;

namespace ToyFactoryLibrary
{
    public class Circle : IToyBlock
    {
        public Colour Colour { get; private set; }

        public Circle(Colour colour)
        {
            Colour = colour;
        }
    }
}