using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{

    public class FillLine : Line
    {

        internal FillLine(FillPage page) : base(page)
        {
        }

        internal override int Length()
        {
            int result = 0;
            foreach (String word in content)
            {
                result += word.Length;
                result += 1;
            }
            result = result - 1; //removes last space.

            if (content.Count() > 1)
            {
                return result;
            }
            else
            {
                return ((FillPage)page).wrap; //this return was added
            }
        }

        internal override bool Overflow()
        {
            return this.WrapOverflow();
        }

        internal virtual bool WrapOverflow() //added virtual
        {
            return Length() > ((FillPage)page).wrap; //changed >= to just >
        }

        internal override void IntoText(StringBuilder text)
        {
            foreach (String word in content)
            {
                text.Append(word.ToString());
                text.Append(" ");
            }
            text.Remove(text.Length - 1, 1);
        }

    }
}
