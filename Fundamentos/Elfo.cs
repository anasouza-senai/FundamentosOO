﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Elfo : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá eu sou o Elfo " + this.Nome + " tenho " + this.Vida + "\npontos de vida, Inteligência: " + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForça: " + this.Forca + "\n Meu nível atual é: " + this.Nivel);
        }
    }
}
