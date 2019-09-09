using ToyFactoryLibrary.Enums;
using ToyFactoryLibrary.Interfaces;

namespace ToyFactoryLibrary
{
    public class Triangle : IToyBlock
    {
        public Colour Colour { get; private set; }

        public Triangle(Colour colour)
        {
            Colour = colour;
        }
    }
}