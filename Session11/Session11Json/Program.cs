using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Session11Json
{
    class Program
    {
        static void Main(string[] args)
        {
            string AppendString(string input) 
		    {
			    return input + AppendString(input);
		    }

		    AppendString(string.Empty);
        }
    }
}
