using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DirAndFileFatory
    {
        public static IDirAndFile GetDirAndFileType(string type)
        {
            if (type == null || type == string.Empty)
            {
                throw new ArgumentNullException("传入参数不可为空");
            }

            switch (type)
            {
                case "CDS": return new CDSDirAndFile();
                case "DebugPanel": return new DebugPanelDirAndFile();
                default:throw new ArgumentException("传入参数有误");
            }
        }
    }
}
