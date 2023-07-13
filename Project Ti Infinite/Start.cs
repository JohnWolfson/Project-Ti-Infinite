using Project_Ti_Infinite.Singletons;
using System;

namespace Project_Ti_Infinite
{
    internal class Start
    {
        static void Main(string[] args)
        {
            Terminal.Instance.Initialise();
            Terminal.Instance.UpdatePlayerDetails();
            Console.ReadLine();
        }
    }
}