﻿using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("*******");
            linkedList.InsertAtParticularPosition(1, 30);
            linkedList.Display();
        }
    }
}
