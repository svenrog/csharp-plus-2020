using System;
using System.Collections.Generic;
using System.Text;

namespace Session10Classes
{
    class RecipePage : Page, IPreamblePage
    {
        public string Preamble { get; set; }
        public Recipe Recipe { get; set; }

        public override int Id 
        {
            get => base.Id; 
            set { base.Id = value; } 
        }

        public override string Render()
        {
            return $"~~~~ Recept ~~~~~~: {Title}";
        }
    }
}
