﻿using System;
using System.Collections.Generic;
using System.Linq;
 

namespace SqlSugarTest
{
    public class TestUpdateColumns
    {
        public Guid VGUID { get; set; }
        public int IdentityField { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}