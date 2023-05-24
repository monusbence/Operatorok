using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hf_2023._05._24_
{
    internal class Operatorok
    {
        int elsoSzam;
        string muveletiJel;
        int masikSzam;

        public Operatorok(string[] adatok)
        {
            this.elsoSzam = Convert.ToInt32(adatok[0]);
            this.muveletiJel = adatok[1];
            this.masikSzam = Convert.ToInt32(adatok[2]);
        }

        public int ElsoSzam { get => elsoSzam; }
        public string MuveletiJel { get => muveletiJel; }
        public int MasikSzam { get => masikSzam; }

        public string HatosFeladat() {
            string[] operatorok = { "+", "-", "*", "/", "mod", "div" };
            if (operatorok.Contains(muveletiJel))
            {
                return "Hibás operátor!";
            }
            if ((muveletiJel == "mod" || muveletiJel == "div" || muveletiJel == "/") && (elsoSzam == 0 || masikSzam == 0))
            {
                return "Egyéb hiba!";
            }

            switch (muveletiJel)
            {
                case "div":
                    return $"{elsoSzam} {muveletiJel} {masikSzam} = {elsoSzam / masikSzam}" ;
                case "mod":
                    return $"{elsoSzam} {muveletiJel} {masikSzam} = {elsoSzam % masikSzam}";
                case "/":
                    return $"{elsoSzam} {muveletiJel} {masikSzam} = {Convert.ToDouble(elsoSzam) / masikSzam}";
                case "-":
                   return $"{elsoSzam} {muveletiJel} {masikSzam} = {elsoSzam - masikSzam}";
                case "+":
                    return $"{elsoSzam} {muveletiJel} {masikSzam} = {elsoSzam + masikSzam}";
                case "*":
                    return $"{elsoSzam} {muveletiJel} {masikSzam} = {elsoSzam * masikSzam}";
                default:
                    return "";
            }

        }
    }
}
