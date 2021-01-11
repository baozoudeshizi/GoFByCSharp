using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DebugPanelDirAndFile : IDirAndFile
    {
        public List<SelectCascadeDTO> GetDirAndFile()
        {
            return new List<SelectCascadeDTO>(){
                new SelectCascadeDTO()
                {
                    label = "DebugPanel",
                    value = "DebugPanel"
                }
            };
            throw new NotImplementedException();
        }
    }
}
