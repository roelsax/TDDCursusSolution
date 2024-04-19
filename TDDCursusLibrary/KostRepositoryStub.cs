using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class KostRepositoryStub : IKostRepository
    {
        public decimal FindTotaleKost()
        {
            return 300;
        }
    }
}
