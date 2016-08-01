using System;
using System.Web.Http;
using ErpNextPoc.Models.InfoSupports;
using System.Web.Http.Description;

namespace ErpNextPoc.Controllers.apis.InfoSupports
{
    public class InfoSupportController : ApiController
    {
        private IInfoSupportService InfoSupportService { get; set; }

        public InfoSupportController(IInfoSupportService infoSupportService)
        {
            this.InfoSupportService = infoSupportService;
        }

        [HttpPost]
        [ResponseType(typeof(void))]
        public void ApproveToNextState(InfoSupport infoSupport)
        {
            this.InfoSupportService.ApproveToNextState(infoSupport);
        }

        [HttpPost]
        [ResponseType(typeof(void))]
        public void Reject(InfoSupport infoSupport)
        {
            this.InfoSupportService.Reject(infoSupport);
        }

        [HttpPost]
        [ResponseType(typeof(void))]
        public void Create(InfoSupport infoSupport)
        {
            this.InfoSupportService.Create(infoSupport);
        }

        [HttpPost]
        [ResponseType(typeof(void))]
        public void Update(InfoSupport infoSupport)
        {
            this.InfoSupportService.Update(infoSupport);
        }
    }
}