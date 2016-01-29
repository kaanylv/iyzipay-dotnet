﻿using System;
using System.Collections.Generic;

namespace Iyzipay.Model
{
    class InstallmentDetail
    {
        public String BinNumber { get; set; }
        public decimal? Price { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamilyName { get; set; }
        public int? Force3Ds { get; set; }
        public long? CardBankCode { get; set; }
        public String CardBankName { get; set; }
        public List<InstallmentPrice> InstallmentPrices { get; set; }
    }
}
