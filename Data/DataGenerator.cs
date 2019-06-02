using System;
using Edliz;
using Edliz.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Edliz
{
    public class DataGenerator
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using (var context = new EdlizContext(
              serviceProvider.GetRequiredService<DbContextOptions<EdlizContext>>()
                )
            )
            {
                
                for(var i = 1;  i< 37; i++){
                    Console.WriteLine("setting up " + i);
                    string fileName = "chapter_" + i + ".js";
                    string path = "resources/pages/";
                    string content = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,path + fileName));
                    Article tmpArticle = new Article(){Id = i, ArticleBody = content};
                    context.Add(tmpArticle);
                }
                context.SaveChanges();
            }
        }

    }
}