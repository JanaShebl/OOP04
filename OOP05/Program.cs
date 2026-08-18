using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // a)  What is Abstraction in Object-Oriented Programming?
            // abstraction is an OOP concept that allow to hide the implementation of an important details and show the essential features

            // b)  Why is abstraction considered one of the four pillars of OOP?
            // because it allows to hide the implementation details and show only the essential features of an object, making it easier to understand and reuse

            #endregion

            #region Q2

            // a)  What is the difference between an Abstract Class and an Interface?
            // abstract class can have concrete methods ,events, properties and fields , interface have only abstract methods, events, properties and fields

            // b)  When would you choose an Interface instead of an Abstract Class?
            // interface provide multiple inheritance and loose coupling , abstract class provide single inheritance which is harder to test and reuse

            // c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // a class can inherit only one class but can implement multiple interfaces


            #endregion

            #region old code

            #endregion

            #region Q3.1

            // Convert Shipment into an Abstract Class

            #endregion

            #region Q3.2,3

            // 2  Create Abstract Members
            // 3  Update All Shipment Types

            #endregion

            #region Q3.4

            // create ITrackable

            #endregion

            #region Q3.5

            // create IInsurable

            #endregion

            #region Q3.6

            // 6  Create DeliveryReport

            #endregion

            #region Q3.7

            // 7  Update DeliveryCenter

            #endregion

            #region Q3.8
            // main

            // Create one StandardShipment.
            StandardShipment s = new StandardShipment("SH001","Laptop",7,45,new DeliveryAddress("cairo","zayed",842));

            // Create one ExpressShipment.
            ExpressShipment e = new ExpressShipment("SH001", "Laptop", 7, 45, new DeliveryAddress("cairo", "zayed", 842),55);

            // Create one InternationalShipment.
            InternationalShipment i = new InternationalShipment("SH001", "Laptop", 7, 45, new DeliveryAddress("cairo", "zayed", 842),"france",555);

            // Add all shipments to the DeliveryCenter.

            DeliveryCenter deliveryCenter = new DeliveryCenter("KK",new Driver("ahmed","445555",455));
            deliveryCenter.AddShipment(i);
            deliveryCenter.AddShipment(s);
            deliveryCenter.AddShipment(e);

            i.PrintShipment();
            e.PrintShipment();
            s.PrintShipment();

            DeliveryReport deliveryReport = new DeliveryReport();
            deliveryReport.PrintInsurance(i);
            deliveryReport.PrintInsurance(s);
            deliveryReport.PrintInsurance(e);

            deliveryReport.PrintShipment(i);
            deliveryReport.PrintShipment(s);
            deliveryReport.PrintShipment(e);


            // مش عارفة اعمل دول ازاي

//            ☐  h.Store the shipment objects in an ITrackable[] array and print their tracking statuses.
//☐  i.Store the shipment objects in an IInsurable[] array and print their insurance values.


            #endregion
        }
    }
}
