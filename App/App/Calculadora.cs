﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Calculadora
    {
        private float numero1;
        private float numero2;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        public float Suma()
        {
            return Numero1 + Numero2;
        }

        public float Resta()
        {
            return Numero1 - Numero2;
        }

        public float Multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public float Division()
        {
            return Numero1 / Numero2;
        }
    }
}