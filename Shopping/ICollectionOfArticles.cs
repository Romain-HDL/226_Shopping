using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal interface ICollectionOfArticles
    {
        void Add(List<Article> articles);
        List<Article> Remove(Boolean empty=false);
        List<Article> Articles { get; }
    }
}
