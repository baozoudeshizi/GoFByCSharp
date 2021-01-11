using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IDirAndFile
    {
        public List<SelectCascadeDTO> GetDirAndFile();
    }


}
