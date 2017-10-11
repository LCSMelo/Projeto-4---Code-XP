using System;
using System.IO;

namespace Projeto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Qual seu nome completo?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            string idade = Console.ReadLine();

            Console.WriteLine("Qual seu local de nascimento?");
            string local = Console.ReadLine();    
            
            
        

            // FileInfo fi = new FileInfo("Arquivo.txt");

            // if(fi.Exists == true)
            // {
            // Console.WriteLine("Tamanho: " + fi.Length + " Bytes");
            // Console.WriteLine("Extensão: " + fi.Extension);
            // Console.WriteLine("Local do arquivo: " + fi.DirectoryName);
            // Console.WriteLine("Criado em: " + fi.CreationTime);
            // }
            // else
            // Console.WriteLine("O arquivo não existe.");
         
            StreamWriter doc = new StreamWriter("Arquivo.csv", true);

            doc.WriteLine("Nome completo: " + nome);
            doc.WriteLine();
            doc.WriteLine("Idade: " + idade);
            doc.WriteLine();
            doc.WriteLine("Local de nascimento: " + local);
            doc.WriteLine();

            doc.Close();

        }
    }
}
