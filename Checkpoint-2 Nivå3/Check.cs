using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2_Nivå3
{
    internal class Check
    {
        public bool Quit(string St)
        {
            if (St.ToLower().Trim() == "q")
            {
                return true;
            }
            else { return false; }
        }
        public bool Null(string St)
        {
            if (St.ToLower().Trim() == "" || St.ToLower().Trim() == null)
            {
                return true;
            }
            else { return false; }
        }
        public bool NewProduct(string St)
        {
            if (St.ToLower().Trim() == "p")
            {
                return true;
            }
            else { return false; }
        }
        public bool Search(string St)
        {
            if (St.ToLower().Trim() == "s")
            {
                return true;
            }
            else { return false; }
        }

    }
}
