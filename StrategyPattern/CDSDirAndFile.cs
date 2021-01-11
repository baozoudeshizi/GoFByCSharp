using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class CDSDirAndFile : IDirAndFile
    {
        public List<SelectCascadeDTO> GetDirAndFile()
        {
            return new List<SelectCascadeDTO>(){
                new SelectCascadeDTO()
                {
                    label = "CDS",
                    value = "CDS"
                }
            };
            throw new NotImplementedException();
        }
    }
}
