using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    

  public class Movie
        {
            public string Title { get; }
            public string Category { get; }

            public Movie(string title, string category)
            {
                Title = title;
                Category = category;
            }
        }
    }

