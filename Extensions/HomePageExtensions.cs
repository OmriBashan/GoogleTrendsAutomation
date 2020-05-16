using System;
using Infrastructure;

namespace Extensions
{
    public static class HomePageExtensions
    {
        public static QueryPage SearchQuery(this HomePage page, string text)
        {
            return page
                .HeaderComponent
                .Search(text);
        }
    }
}
