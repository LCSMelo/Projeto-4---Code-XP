using System;
using System.IO;

namespace Projeto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileInfo fi = new FileInfo("Arquivo.txt");

            if(fi.Exists == true)
            {
            Console.WriteLine("Tamanho: " + fi.Length + " Bytes");
            Console.WriteLine("Extensão: " + fi.Extension);
            Console.WriteLine("Local do arquivo: " + fi.DirectoryName);
            Console.WriteLine("Criado em: " + fi.CreationTime);
            }
            else
            {
                Console.WriteLine("O arquivo não existe.");
            }
            StreamWriter sw = new StreamWriter("Arquivo.txt", true);

            sw.WriteLine("asdfasdfasdf");
            sw.WriteLine("asdf asdf asdf");


            sw.Close();

        }
    }
}
