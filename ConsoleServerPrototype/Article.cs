using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleServerPrototype
{
    /// <summary>
    /// A class to encapsulate an article for the app.
    /// </summary>
    class Article
    {
        public Uri Address;
        public DateTime Date;

        public Category Category;

        public string Name;
        public string Author; // for opinion and blog categories.

        public List<string> Keywords; // aka tags, i.e. mentioned people, organizations, companies, etc.

        // ? article's text, html file ?
    }
}
