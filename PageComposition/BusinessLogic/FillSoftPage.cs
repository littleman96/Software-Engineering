using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FillSoftPage : FillPage
    {
        internal int wrapsoft;
        internal int linecount;

        internal FillSoftPage(int wrap, int wrapsoft) : base(wrap)
        {
            this.wrapsoft = wrapsoft; 
            content = new List<Line>();
            AddLine();
        }

        internal override void AddLine()
        {
            currentLine = new FillSoftLine(this);
            content.Add(currentLine);
            linecount = linecount + 1;
        }

        internal override bool Overflow()
        {
            foreach (Line line in content)
            {
                if (line.Overflow())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
