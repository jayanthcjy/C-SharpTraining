using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Models
{
    public class SocialLinksViewComponent : ViewComponent
    {
        List<SocialIcon> socialIcons = new List<SocialIcon>();
        public SocialLinksViewComponent()
        {
            socialIcons = SocialIcon.AppSocialIcons();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = socialIcons;
            return await Task.FromResult((IViewComponentResult)View("SocialLinks", model));
        }

    }
}
