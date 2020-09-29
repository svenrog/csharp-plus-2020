using System;
using System.Collections.Generic;
using System.Text;

namespace Session10Classes
{
    class FaqPage : Page, IPreamblePage
    {
        public string Preamble { get; set; }
        public List<AnsweredQuestion> Questions { get; set; }

        public override string Render()
        {
            return ToString();
        }
    }
}
