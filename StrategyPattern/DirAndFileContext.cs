using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //具体的策略控制类
    public class DirAndFileContext
    {
        private IDirAndFile dirAndFile;

        public DirAndFileContext(IDirAndFile dirAndFile)
        {
            this.dirAndFile = dirAndFile;
        }
        public List<SelectCascadeDTO> GetDirAndFile()
        {
            return dirAndFile.GetDirAndFile();
        }
    }
}
