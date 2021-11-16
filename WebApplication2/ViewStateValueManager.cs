using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication2
{
    public class ViewStateValueManager : IViewStateValueManager
    {
        private readonly StateBag ViewState;
        public ViewStateValueManager()
        {

        }

        public ViewStateValueManager(StateBag _ViewState)
        {
            ViewState = _ViewState;
        }
        public T GetValueFromViewState<T>(string paramValue)
        {

            return (T)ViewState[paramValue];

        }

        public void PutValueToViewState<T>(string paramValue, T storeValue)
        {
            ViewState[paramValue] = storeValue;

        }
    }
}