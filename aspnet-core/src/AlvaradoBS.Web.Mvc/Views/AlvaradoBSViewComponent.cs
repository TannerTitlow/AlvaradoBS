using Abp.AspNetCore.Mvc.ViewComponents;

namespace AlvaradoBS.Web.Views
{
    public abstract class AlvaradoBSViewComponent : AbpViewComponent
    {
        protected AlvaradoBSViewComponent()
        {
            LocalizationSourceName = AlvaradoBSConsts.LocalizationSourceName;
        }
    }
}
