﻿using Com.Anqa.Service.Warehouse.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Warehouse.Lib.ViewModels.SOViewModel
{
    public class SODocsCsvViewModel : BaseViewModel
    {
        public string code { get; set; }
        public string name { get; set; }
        public dynamic quantity { get; set; }
    }
}