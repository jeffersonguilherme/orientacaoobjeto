﻿using ProjetoBalta.ContentContext;

namespace ProjetoBalta {
    class Program {
    static void Main(string[] args){

        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "orientacao-c#"));
        articles.Add(new Article("Artigo sobre .NET", "orientacao-net"));

            foreach(var article in articles){
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }

}