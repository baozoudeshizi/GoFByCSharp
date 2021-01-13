using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface ICommodity
    {
        /// <summary>
        /// 所有的奖品⽆无论是实物、虚拟还是第三⽅方，都需要通过我们的程序实现此接⼝口进⾏行行处理理，以保证最终⼊入参出参的统⼀性。
        /// 接⼝口的⼊入参包括； ⽤用户ID 、 奖品ID 、 业务ID 以及 扩展字段 ⽤用于处理理发放实物商品时的收获地址。
        /// </summary>

        public void SendCommodity() ;
    }
}
