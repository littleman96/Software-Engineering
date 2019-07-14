using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FillSoftLine : FillLine
    {
        internal FillSoftLine (FillSoftPage page) : base(page)
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
            result = result - 1;

            if (content.Count() > 1)
            {
                return result;
            }
            else
            {
                return ((FillSoftPage)page).wrapsoft;
            }
        }

        internal override bool Overflow()
        {
            return this.WrapOverflow();
        }

        /// <summary>
        /// this needs the if statement sorting.
        /// </summary>
        /// <returns></returns>
        internal override bool WrapOverflow()
        {
            if ()
            {
                return Length() > ((FillSoftPage)page).wrap;
            }
            else
            {
                return Length() > ((FillSoftPage)page).wrapsoft;
            }
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

