using System;
using System.Collections.Generic;
using ToyFactoryLibrary.Blocks;
using ToyFactoryLibrary.Enums;
using ToyFactoryLibrary.Interfaces;

namespace ToyFactoryLibrary
{
    public class Order : IOrder
    {
        public string Name { get; }
        public string Address { get; }
        public DateTime DueDate { get; }
        public int OrderNumber { get; } 
        public IResponseManager ResponseManager { get; }
        public IToyBlocksList ToyBlocksList { get; set; }

        public Order(string name, string address, in DateTime dueDate, int orderNumber, IResponseManager responseManager, IToyBlocksList toyBlocksList)
        {
            Name = name;
            Address = address;
            DueDate = dueDate;
            OrderNumber = orderNumber;
            ResponseManager = responseManager;
            ToyBlocksList = toyBlocksList;
        }

        public void CreateToyBlocks()
        {
            var max = ResponseManager.GetRedSquares();
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Square(Colour.Red));

            max = ResponseManager.GetBlueSquares();
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Square(Colour.Blue));

            max = ResponseManager.GetYellowSquares(); 
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Square(Colour.Yellow));

            max = ResponseManager.GetRedTriangles(); 
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Triangle(Colour.Red));

            max = ResponseManager.GetBlueTriangles(); 
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Triangle(Colour.Blue));

            max =  ResponseManager.GetYellowTriangles(); 
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Triangle(Colour.Yellow));

            max = ResponseManager.GetRedCircles();
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Circle(Colour.Red));

            max = ResponseManager.GetBlueCircles();
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Circle(Colour.Blue));
            
            max = ResponseManager.GetYellowCircles();
            for (var i = 0; i < max; i++) ToyBlocksList.Add(new Circle(Colour.Yellow));
            
        }
    }
}