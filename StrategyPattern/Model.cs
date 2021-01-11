using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Model
    {

    }

    public class SelectCascadeDTO
    {
        public string label { get; set; }
        public string value { get; set; }

        public List<SelectCascadeDTO> children { get; set; } = new List<SelectCascadeDTO>();
    }
}
