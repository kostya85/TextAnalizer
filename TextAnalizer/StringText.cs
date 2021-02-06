using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    class StringText : IContent
    {
        private string _content;        

        public string Content { get => _content; set => _content=value; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
