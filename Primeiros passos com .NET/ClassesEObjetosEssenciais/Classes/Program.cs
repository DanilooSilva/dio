﻿using System;
using Classes.Heranca;

namespace Classes
{
    class Program
    {
        static void Main(String[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto3D p2 = new Ponto3D(10, 20, 30);
            
            Ponto3D.Calcular();
        }
    }
}