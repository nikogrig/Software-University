﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        Scale<int> scale = new Scale<int>(6, 5);

        Console.WriteLine(scale.GetHavier());
    }
}

