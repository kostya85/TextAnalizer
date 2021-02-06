using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    class GlasMetric : IMetric
    {
        private string _info;
        public string Info { get => _info; set => _info=value; }

        public Task Analyse(IContent content)
        {
            int count = content.Content.Length;
            _info = count.ToString();
            return Task.CompletedTask;
        }
    }
}
