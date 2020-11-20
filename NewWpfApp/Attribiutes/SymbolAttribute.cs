using System;

namespace NewWpfApp.Attribiutes
{
    public class SymbolAttribute : Attribute
    {
        public string Symbol { get; private set; }

        public SymbolAttribute(string symbol)
        {
            Symbol = symbol;
        }
    }
}
