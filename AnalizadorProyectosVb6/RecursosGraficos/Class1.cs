using Antlr4.Runtime;
/// using AnalizadorProyectosVb6.Grammar; // Ajusta según tu namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorProyectosVb6.RecursosGraficos
{
    internal class Class1
    {
        internal void Prueba()
        {
            // 1. Leer el archivo de código fuente de VB6
            string inputCode = File.ReadAllText("ruta_de_tu_archivo.cls");

            // 2. Pasar el texto al Lexer (Analizador Léxico)
            var inputStream = CharStreams.fromString(inputCode);
            var lexer = new VisualBasic6Lexer(inputStream);

            // 3. Pasar los tokens al Parser (Analizador Sintáctico)
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new VisualBasic6Parser(tokenStream);

            // 4. Comenzar el análisis desde la regla inicial de tu gramática
            var tree = parser.startRule(); // Cambia 'startRule' por la regla raíz de tu arc
        }
    }
}



