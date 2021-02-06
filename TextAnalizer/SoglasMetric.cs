using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalizer
{
    class SoglasMetric : IMetric
    {
        private string _info;
        public string Info { get => _info; set => _info=value; }

        public Task Analyse(IContent content)
        {
            int count = 0;
            foreach(var e in content.Content.ToString())
            {
                if (!GlasMetric.alphabet.Contains(char.ToLower(e)))
                {
                    count++;
                }

            }
            Info = "Количество согласных букв: " + count + ";\n";
            return Task.CompletedTask;
        }
    }
}
