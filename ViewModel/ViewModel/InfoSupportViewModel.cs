using System;

namespace Aurora.ErpNext.ViewModel
{
    public class InfoSupportViewModel
    {
        public string Context { get; set; }

        public string Docno { get; set; }

        public string FilePath { get; set; }

        public DateTime ManagerApproveTime { get; set; }

        public string ManagerEMPNO { get; set; }

        public SeviceTypeEnum ServiceType { get; set; }

        public InfoSupportStateEnum State { get; set; }

        public string Title { get; set; }
    }
}