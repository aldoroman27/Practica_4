using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public class Token
    {
        public string Type { get; set; }
        public string Lexeme { get; set; }

        public Token(string type, string lexeme)
        {
            Type = type;
            Lexeme = lexeme;
        }

        public override string ToString()
        {
            return $"{Type}: {Lexeme}";
        }
    }
}
