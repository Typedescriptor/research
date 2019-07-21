using System;
using System.IO;
using Markdig;
using Markdig.Syntax;

namespace Typedescriptor.Research.MarkdownProject
{
    static class Program
    {
        public static void Converting_a_Markdown_file_to_html()
        {
            var markdownFile = "./facts/minimal.md";
            var text = File.ReadAllText(markdownFile);
            var html = Markdown.ToHtml(text);

            Console.WriteLine(html);
        }

        public static void Converting_a_Markdown_string_to_html()
        {
            var markdownString = "# 3-Minute Markdown Overview\n\n"
                + "Markdown consists of two types of lexical constructs: inlines and blocks.\n";
            var html = Markdown.ToHtml(markdownString);

            Console.WriteLine(html);
        }

        public static void Parsing_markdown_into_a_syntax_tree()
        {
            var markdownFile = "./facts/minimal.md";
            var text = File.ReadAllText(markdownFile);
            MarkdownDocument doc = Markdown.Parse(text);
            foreach (var block in doc) {
                Console.WriteLine($"Block type: {block.GetType().Name}");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Not meant to be run directly");
        }
    }
}
