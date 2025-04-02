using EasyArchitectCore.Core;
using Microsoft.AspNetCore.Http;

namespace EasyArchitectV2Lab10.AuthExtensions10.Extensions
{
    public class UriExtensions : IUriExtensions
    {
        public string GetAbsoluteUri(HttpRequest httpRequest)
        {
            return httpRequest.Scheme + "://" + httpRequest.Host.ToUriComponent() + httpRequest.PathBase.ToUriComponent() + httpRequest.Path.ToUriComponent() + httpRequest.QueryString.ToUriComponent();
        }

        public string GetAbsoluteUri(HttpRequest httpRequest, string customPathUri)
        {
            return httpRequest.Scheme + "://" + httpRequest.Host.ToUriComponent() + httpRequest.PathBase.ToUriComponent() + customPathUri + httpRequest.QueryString.ToUriComponent();
        }
    }
}
