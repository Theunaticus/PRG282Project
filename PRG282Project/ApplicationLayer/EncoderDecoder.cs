using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.ApplicationLayer
{
    class EncoderDecoder
    {
        struct Combo
        {
            public string A;
            public string B;

            public Combo(string _A, string _B)
            {
                A = _A;
                B = _B;
            }
        }

        static Combo[] Code = {
            new Combo("A","f"),
            new Combo("B","s"),
            new Combo("C","S"),
            new Combo("D","d"),
            new Combo("E","D"),
            new Combo("F","l"),
            new Combo("G","y"),
            new Combo("H","M"),
            new Combo("I","i"),
            new Combo("J","H"),
            new Combo("K","Z"),
            new Combo("L","E"),
            new Combo("M","T"),
            new Combo("N","o"),
            new Combo("O","R"),
            new Combo("P","x"),
            new Combo("Q","t"),
            new Combo("R","U"),
            new Combo("S","g"),
            new Combo("T","C"),
            new Combo("U","G"),
            new Combo("V","L"),
            new Combo("W","a"),
            new Combo("X","N"),
            new Combo("Y","m"),
            new Combo("Z","Q"),
            new Combo(" ","e"),
            new Combo("a","K"),
            new Combo("b","u"),
            new Combo("c","F"),
            new Combo("d","p"),
            new Combo("e","V"),
            new Combo("f","z"),
            new Combo("g","O"),
            new Combo("h","j"),
            new Combo("i","W"),
            new Combo("j","v"),
            new Combo("k","Y"),
            new Combo("l","n"),
            new Combo("m","I"),
            new Combo("n","q"),
            new Combo("o","_"),
            new Combo("p","w"),
            new Combo("q","A"),
            new Combo("r","h"),
            new Combo("s","P"),
            new Combo("t","b"),
            new Combo("u","X"),
            new Combo("v","J"),
            new Combo("w","k"),
            new Combo("x","B"),
            new Combo("y","r"),
            new Combo("z","c"),
        };

        public static string Encode(string Input)
        {
            string Output = "";
            for (int i = 0; i < Input.Length; i++)
            {
                Output += Match(Input[i].ToString());
            }
            return Output;
        }

        public static string Decode(string Input)
        {
            string Output = "";
            for (int i = 0; i < Input.Length; i++)
            {
                Output += Unmatch(Input[i].ToString());
            }
            return Output;
        }

        static string Unmatch(string B)
        {
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i].B == B)
                {
                    return Code[i].A;
                }
            }
            return B;
        }

        static string Match(string A)
        {
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i].A == A)
                {
                    return Code[i].B;
                }
            }
            return A;
        }
    }
}
