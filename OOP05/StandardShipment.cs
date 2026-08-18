using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    internal class StandardShipment : Shipment
    {
        // Create a constructor that initializes all inherited members using constructor chaining. 
        // constructor chaining is done by calling the base class
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
        }
    }
}
