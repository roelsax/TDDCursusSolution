using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class OpbrengstRepositoryStub : IOpbrengstRepository
    {
        public decimal FindTotaleOpbrengst()
        {
            return 500;
        }
    }
}
