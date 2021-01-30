using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace editorhtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            DrawnStatic();
            WriteOptions();

            var options = short.Parse(Console.ReadLine());
            HandleMenuOptions(options);
        }

        public static void DrawnStatic()
        {
            InicioDrawn();
            FimDrawn();
            InicioDrawn();
        }

        public static void InicioDrawn()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void FimDrawn()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("--------------------");

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("2 - Abrir arquivo");

            Console.SetCursorPosition(2, 7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 8);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOptions(short options)
        {
            switch (options)
            {
                case 1: Editor.Show(); break;
                case 2: Editor.Show(); break;
                case 0: System.Environment.Exit(0); break;
                default: Show(); break;
            }
        }
    }
}
