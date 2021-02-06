using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    class TXText : IContent
    {
        string _path;
        public string Path { get => _path; set => _path=value; }
        public string Content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
