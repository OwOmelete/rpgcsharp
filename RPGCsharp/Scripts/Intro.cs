using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


namespace RPGCsharp
{
    public class Intro
    {
        public void intro()
        {
            Console.Write("Enter a name !");
            string Name = Console.ReadLine();
            Console.Write("You are a knight named" + Name);
            Console.Write("your goal ... kill as many monster as you can");
            
            
            
        }
    }
}