using System.Collections.Generic;

namespace CalculatorParser
{
    public enum TokenType
    {
        // 不正なトークン
        ILLEGAL,
        // 現在不明
        UNKNOWN,
        // 終端
        EOF,
        // 括弧
        LPARAM,
        RPARAM,
        // 演算子
        MULITPLY,
        DIVIDE,
        PLUS,
        MINUS,
        // 数値
        NUBER,
        // 小数点
        DOT,
    }

    public class Token
    {
        public TokenType Type { get; set; }
        public string Literal { get; set; }

        public Token(TokenType type, string literal)
        {
            this.Type = type;
            this.Literal = literal;
        }

        public static TokenType LookupOperators(char c)
        {
            var Operators = new Dictionary<char, TokenType>
            {
                ['('] = TokenType.LPARAM,
                [')'] = TokenType.RPARAM,
                ['+'] = TokenType.PLUS,
                ['-'] = TokenType.MINUS,
                ['*'] = TokenType.MULITPLY,
                ['/'] = TokenType.DIVIDE,
                ['.'] = TokenType.DOT,
            };

            if (Operators.ContainsKey(c))
            {
                return Operators[c];
            }
            return TokenType.UNKNOWN;
        }
    }
}
