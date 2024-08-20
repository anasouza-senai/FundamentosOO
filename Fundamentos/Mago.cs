using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Mago : Personagem
    {

        public override void apresentarSe()
        {
            Console.WriteLine("Olá eu sou Mago " + this.Nome + "tenho" + this.Vida + "\npontos de vida , Inteligência: " + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForça: " + this.Forca + "\n Meu nível atual é: " + this.Nivel);
        }

    }
}
