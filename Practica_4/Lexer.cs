using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Practica_4
{
    public class Lexer
    {
        private string input;
        private int position;

        private static readonly Dictionary<string, string> tokenPatterns = new Dictionary<string, string>
        {
            { "NUMBER", @"^\d+" },
            { "ID", @"^[a-zA-Z_][a-zA-Z0-9_]*" },
            { "PLUS", @"^\+" },
            { "MINUS", @"^-" },
            { "MULTIPLY", @"^\*" },
            { "DIVIDE", @"^/" },
            { "LPAREN", @"^\(" },
            { "RPAREN", @"^\)" },
            { "ASSIGN", @"^=" },
            { "WHITESPACE", @"^\s+" },
        };
        public Lexer(string input)
        {
            this.input = input;
            this.position = 0;
        }

        public List<Token> Tokenize()
        {
            List<Token> tokens = new List<Token>();

            while (position < input.Length)
            {
                bool matched = false;
                foreach (var pattern in tokenPatterns)
                {
                    var regex = new Regex(pattern.Value);
                    var match = regex.Match(input.Substring(position));
                    if (match.Success)
                    {
                        if(pattern.Key != "WHITESPACE")//Ignoramos los espacios
                        {
                            tokens.Add(new Token(pattern.Key, match.Value));
                        }
                        position += match.Length;
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                {
                    throw new Exception($"Caracter no valido en la posición {position}: '{input[position]}'");
                }
            }
            return tokens;
        }

    }
}
