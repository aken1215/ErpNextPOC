using ErpNextPoc.Models.InfoSupports.Models.InfoSupports;
using System.Collections.Generic;

namespace ErpNextPoc.Models.InfoSupports
{
    public class InfoSupport
    {
        public InfoSupport(string docno)
        {
            this.Docno = docno;
        }

        public InfoSupport()
        {
        }

        public string Docno { get; set; }

        public string Description { get; set; }

        public string InfoManagerSuggestion { get; set; }

        public InfoSupportEnum State { get; set; }

        public string Title { get; set; }

        public int WorkHours { get; set; }

        public int Price { get; set; }

        public Employee ApplicantManager { get; set; }

        public ServiceEnum ServiceType { get; set; }

        public ICollection<FileData> Files { get; set; }
        public string ErrorMessage { get; set; }
        public Employee InfoAgent { get; set; }

        public InfoModuleEnum AssignedInfoModule;
    }
}