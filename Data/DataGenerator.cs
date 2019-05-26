using System;
using Edliz;
using Edliz.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
                //Check if data is already seeded here
                if(context.Articles.Any()){
                    return;
                }
                
                //Data will be instantiated here
                context.AddRange(
                    new Article(),
                    new Article()
                );

                context.SaveChanges();
            }
        }

    }
}