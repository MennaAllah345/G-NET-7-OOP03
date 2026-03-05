using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1 :
            //Q1: Identify the type of relationship

            //a) Composition
            //Because the Departments cannot exist without the University.If the university is closed, the departments are destroyed as well.

            //b) Association
            //Because the Driver only uses the Car, but does not own it. Both objects can exist independently.

            //c) Inheritance
            //Because Dog is a type of Animal. The Dog class inherits from the Animal class.

            //d) Aggregation
            //Because Players can exist without the Team.If the team is deleted, the players still exist.

            //e) Dependency
            //Because the method temporarily uses the Logger object as a parameter only inside the method.
            #endregion

            #region Q2 :
            //Q2: Access Modifiers and Sealed

            // a) Yes, a child class in a different assembly can access a protected field, but only through inheritance(inside the child class).
            //However, it cannot be accessed through an object instance from outside the class.

            //b)protected internal: Accessible from the same assembly OR from derived classes in other assemblies.

            // //c)private protected: Accessible only within the same assembly AND only in derived classes.
            //sealed class: Prevents other classes from inheriting from it.
            //sealed method: Prevents a derived class from overriding that method again.


            ////d)Yes, you can create an object from a sealed class using new because sealed only prevents inheritance, not object creation.

            #endregion

            #endregion

            #region Part 02 : Practical

            Cinema cinema = new Cinema("Cairo Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            cinema.CloseCinema();
            #endregion
        }
    }
}
