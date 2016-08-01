using Aurora.ErpNext.ViewModel;
using ErpNextPoc.Models.InfoSupports;

namespace ErpNextPoc
{
    public interface IInfoSupportService
    {
        void Update(InfoSupport model);

        void ApproveToNextState(InfoSupport infoSupport);

        void Reject(InfoSupport infoSupport);

        void Create(InfoSupport infoSupport);
    }
}