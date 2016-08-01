using System;
using Aurora.ErpNext.ViewModel;
using ErpNextPoc.Models.InfoSupports;
using ErpNextPoc.Repositories.InfoSupports;

namespace ErpNextPoc
{
    public class InfoSupportService : IInfoSupportService
    {
        private IInfoSupportRepository InfoSupportRepository { get; set; }

        public InfoSupportService(IInfoSupportRepository infoSupportRepository)
        {
            this.InfoSupportRepository = infoSupportRepository;
        }

        public void ApproveToNextState(InfoSupport infoSupport)
        {
            this.InfoSupportRepository.Update(infoSupport);
        }

        public void Create(InfoSupport infoSupport)
        {
            this.InfoSupportRepository.Crate(infoSupport);
        }

        public void Reject(InfoSupport infoSupport)
        {
            this.InfoSupportRepository.Update(infoSupport);
        }

        public void Update(InfoSupport infoSupport)
        {
            this.InfoSupportRepository.Update(infoSupport);
        }
    }
}