using System;
using System.Collections.Generic;
using System.Text;

namespace Session10GenericsExamples
{
    interface IIndexDocument<T>
    {
        Guid Id { get; }
        T Document { get; }
    }
}
