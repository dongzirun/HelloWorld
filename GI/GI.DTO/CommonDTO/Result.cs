using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DTO
{
    public class Result
    {
        public bool Res { get; set; }
        public string Msg { get; set; }
        public Object Data { get; set; }
        public Result(bool res, string msg) { Res = res; Msg = msg; }
    }
}
