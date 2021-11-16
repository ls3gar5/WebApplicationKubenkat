using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Contact : Page
    {
        public const string S_DATOS_TO_CONFIRM = "S_DATOS_TO_CONFIRM";
        private readonly IViewStateValueManager _viewStateValueManager;
        public Contact()
        {
            _viewStateValueManager = new ViewStateValueManager(ViewState);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
               
                _viewStateValueManager.PutValueToViewState<int>(S_DATOS_TO_CONFIRM, 0);
                this.txtCounter.Text = "0";
            }
        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {

            var stateValueCounter = _viewStateValueManager.GetValueFromViewState<int>(S_DATOS_TO_CONFIRM);
            stateValueCounter += 1;
            this.txtCounter.Text = stateValueCounter.ToString();

            _viewStateValueManager.PutValueToViewState<int>(S_DATOS_TO_CONFIRM, stateValueCounter);

        }

       
    }
}