using ErpNextPoc.Models.InfoSupports;

namespace ErpNextPoc.Repositories.InfoSupports
{
    public interface IInfoSupportRepository
    {
        void Update(InfoSupport infoSupport);
        void Crate(InfoSupport infoSupport);
    }
}