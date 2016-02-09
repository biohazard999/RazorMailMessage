using System.Collections.Generic;
using System.Net.Mail;
using RazorEngine.Templating;

namespace RazorMailMessage
{
    public interface IRazorMailMessageFactory<out TMailMessage, in TLinkedResource>
    {
        TMailMessage Create<TModel>(string templateName, TModel model);
        TMailMessage Create<TModel>(string templateName, TModel model, DynamicViewBag viewBag);
        TMailMessage Create<TModel>(string templateName, TModel model, IEnumerable<TLinkedResource> linkedResources);
        TMailMessage Create<TModel>(string templateName, TModel model, DynamicViewBag viewBag, IEnumerable<TLinkedResource> linkedResources);
    }
}