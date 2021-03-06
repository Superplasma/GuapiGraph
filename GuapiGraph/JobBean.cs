﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuapiGraph
{
    class JobBean
    {
        public string company {get; set;}   //公司名字
        public string month { get; set; }   //日期
        public string position { get; set; } //运维 前端 后台
        public List<string> adjList { get; set; } //形容词词频
        public List<string> skillList { get; set; }//java/c++/python
    }
}
