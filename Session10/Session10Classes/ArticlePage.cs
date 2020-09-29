using System;
using System.Collections.Generic;
using System.Text;

namespace Session10Classes
{
    class ArticlePage : Page
    {
        public string Preamble { get; set; }
        public string MainBody { get; set; }

        public override string Render()
        {
            return ToString();
        }
    }
}
