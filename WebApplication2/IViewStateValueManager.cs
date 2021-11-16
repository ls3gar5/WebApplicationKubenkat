

namespace WebApplication2
{
    public interface IViewStateValueManager
    {
        T GetValueFromViewState<T>(string paramValue);
        void PutValueToViewState<T>(string paramValue, T storeValue);
    }
}