﻿using DotLiquid;

namespace VirtoCommerce.Web.Models
{
    public class QuoteTotals : Drop
    {
        public decimal OriginalSubTotalExlTax { get; set; }

        public decimal SubTotalExlTax { get; set; }

        public decimal ShippingTotal { get; set; }

        public decimal DiscountTotal { get; set; }

        public decimal TaxTotal { get; set; }

        public decimal AdjustmentQuoteExlTax { get; set; }

        public decimal GrandTotalExlTax { get; set; }

        public decimal GrandTotalInclTax { get; set; }
    }
}