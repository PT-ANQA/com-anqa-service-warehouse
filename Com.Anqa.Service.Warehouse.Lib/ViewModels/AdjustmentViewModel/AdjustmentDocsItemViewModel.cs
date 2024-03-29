﻿using Com.Anqa.Service.Warehouse.Lib.Utilities;
using Com.Anqa.Service.Warehouse.Lib.ViewModels.NewIntegrationViewModel;
using System.ComponentModel.DataAnnotations;

namespace Com.Anqa.Service.Warehouse.Lib.ViewModels.AdjustmentDocsViewModel
{
    public class AdjustmentDocsItemViewModel : BaseViewModel
    {
        public ItemViewModel item { get; set; }
        public double qtyBeforeAdjustment { get; set; }
        public double qtyAdjustment { get; set; }
        public string remark { get; set; }
        public string type { get; set; }

    }

}
