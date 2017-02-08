using System;
using System.Collections.Generic;

namespace AspNetCoreSPA.Model.POCOs
{
    public partial class ItemsOfPackage
    {
        public int IopAckageId { get; set; }
        public int? PackageId { get; set; }
        public string IofDescriptionEn { get; set; }
        public string IofDesctiptionSrb { get; set; }
        public string IofNameEn { get; set; }
        public string IofNameSrb { get; set; }

        public virtual InsurancePackage Package { get; set; }
    }
}
