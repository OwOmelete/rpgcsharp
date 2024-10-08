using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using RPGCsharp.Scripts;


namespace RPGCsharp
{
    public class Intro
    {
        
        public string Txtintro()
        {
            Console.WriteLine("Enter a name!");
            string name = Console.ReadLine();
            Console.Write("You are a knight named " + name);
            Console.WriteLine(", your goal kill as many monster as you can ");
            //Console.Write("");

            return name;

        }
    }
}