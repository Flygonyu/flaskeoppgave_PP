using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flaskeoppgave_PP
{
    internal class Bottle
    {
        public int Capacity { get; private set; }
        public int Content { get; private set; }

        public Bottle(int capacity)
        {
            Capacity = capacity;
        }

        public int Empty()
        {
            int emptiedContent = Content;
            Content = 0;
            return emptiedContent;
        }

        public void FillToTopFromTap()
        {
            Content = Capacity;
        }

        public void Fill(int emptiedContent)
        {
            var missingContent = Capacity - Content;
            if (emptiedContent == 0) return;

            if ((Content += emptiedContent) > Capacity) Content += missingContent;
            else Content += emptiedContent;
            
        }

        public void FillToTop(Bottle bottle)
        {
            var missingContent = Capacity - Content;
            if (bottle.Content < missingContent) return;
            bottle.Content -= missingContent;
            Content += missingContent;
        }
    }
}
