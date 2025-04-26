using System;
using System.Collections.Generic;

namespace Practica_4
{
    public class Parser
    {
        private List<Token> tokens;
        private int currentTokenIndex;
        private Token CurrentToken => currentTokenIndex < tokens.Count ? tokens[currentTokenIndex] : null;

        private Dictionary<string, double> variables; // ¡Ya no se crea adentro!

        public Parser(List<Token> tokens, Dictionary<string, double> variables)
        {
            this.tokens = tokens;
            this.currentTokenIndex = 0;
            this.variables = variables; // ¡Recibimos las variables externas!
        }

        private void Match(string expectedType)
        {
            if (CurrentToken != null && CurrentToken.Type == expectedType)
            {
                currentTokenIndex++;
            }
            else
            {
                throw new Exception($"Error de sintaxis: se esperaba {expectedType}, se encontró {CurrentToken?.Type ?? "fin de entrada"}");
            }
        }

        public double Parse()
        {
            var result = Statement();
            if (CurrentToken != null)
            {
                throw new Exception($"Error de sintaxis inesperado en token {CurrentToken.Lexeme}");
            }
            return result;
        }

        private double Statement()
        {
            if (CurrentToken != null && CurrentToken.Type == "ID" && PeekNext()?.Type == "ASSIGN")
            {
                string varName = CurrentToken.Lexeme;
                Match("ID");
                Match("ASSIGN");
                double value = Expression();
                variables[varName] = value;
                return value;
            }
            else
            {
                return Expression();
            }
        }

        private double Expression()
        {
            double result = Term();

            while (CurrentToken != null && (CurrentToken.Type == "PLUS" || CurrentToken.Type == "MINUS"))
            {
                if (CurrentToken.Type == "PLUS")
                {
                    Match("PLUS");
                    result += Term();
                }
                else if (CurrentToken.Type == "MINUS") // <- Aquí estaba el error: "Minus" (mal escrito)
                {
                    Match("MINUS");
                    result -= Term();
                }
            }
            return result;
        }

        private double Term()
        {
            double result = Factor();

            while (CurrentToken != null && (CurrentToken.Type == "MULTIPLY" || CurrentToken.Type == "DIVIDE"))
            {
                if (CurrentToken.Type == "MULTIPLY")
                {
                    Match("MULTIPLY");
                    result *= Factor();
                }
                else if (CurrentToken.Type == "DIVIDE")
                {
                    Match("DIVIDE");
                    double divisor = Factor();
                    if (divisor == 0)
                    {
                        throw new Exception("Error: División entre cero");
                    }
                    result /= divisor;
                }
            }
            return result;
        }

        private double Factor()
        {
            if (CurrentToken.Type == "NUMBER")
            {
                double value = double.Parse(CurrentToken.Lexeme);
                Match("NUMBER");
                return value;
            }
            else if (CurrentToken.Type == "ID")
            {
                string varName = CurrentToken.Lexeme;
                Match("ID");
                if (!variables.ContainsKey(varName))
                {
                    throw new Exception($"Error: variable '{varName}' no definida");
                }
                return variables[varName];
            }
            else if (CurrentToken.Type == "LPAREN")
            {
                Match("LPAREN");
                double value = Expression();
                Match("RPAREN");
                return value;
            }
            else
            {
                throw new Exception($"Error de sintaxis inesperado en token {CurrentToken?.Lexeme ?? "fin de entrada"}");
            }
        }

        private Token PeekNext()
        {
            int nextIndex = currentTokenIndex + 1;
            return nextIndex < tokens.Count ? tokens[nextIndex] : null;
        }
    }
}
