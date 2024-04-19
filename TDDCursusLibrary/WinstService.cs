using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class WinstService
    {
        private readonly IKostRepository KostRepository = null!;
        private readonly IOpbrengstRepository OpbrengstRepository = null!;

        public WinstService(IKostRepository kostRepository, IOpbrengstRepository opbrengstRepository)
        {
            KostRepository = kostRepository;
            OpbrengstRepository = opbrengstRepository;
        }
        private decimal winst;
        public decimal Winst { get { return winst; } }
        public decimal GetWinst()
        {
            winst = OpbrengstRepository.FindTotaleOpbrengst() - KostRepository.FindTotaleKost();
            return Winst;
        }
    }
}
