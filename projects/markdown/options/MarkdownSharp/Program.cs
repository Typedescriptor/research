using System;
using System.IO;
using MarkdownSharp;

namespace Typedescriptor.Research.MarkdownProject
{
    static class Program
    {
        public static void Converting_a_Markdown_file_to_html()
        {
            var markdownFile = "./facts/minimal.md";
            var text = File.ReadAllText(markdownFile);
            var html = new Markdown().Transform(text);

            Console.WriteLine(html);
        }

        public static void Converting_a_Markdown_string_to_html()
        {
            var markdownString = "# 3-Minute Markdown Overview\n\n"
                + "Markdown consists of two types of lexical constructs: inlines and blocks.\n";
            var html = new Markdown().Transform(markdownString);

            Console.WriteLine(html);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Not meant to be run directly");
        }
    }
}
