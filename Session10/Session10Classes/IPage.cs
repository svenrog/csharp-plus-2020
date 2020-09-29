using System;
using System.Collections.Generic;
using System.Text;

namespace Session10Classes
{
    public interface IPage
    {
        int Id { get; }
        string Title { get; set; }

        string Render();
    }
}
