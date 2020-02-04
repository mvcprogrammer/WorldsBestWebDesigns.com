using System.Web.Mvc;
using WorldsBestWebDesigns.com.Factories.Email;
using WorldsBestWebDesigns.com.Models;

namespace WorldsBestWebDesigns.com.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public ActionResult ContactMe(ContactRequest contactRequest)
        {
            string emailTemplate = ContactResponse(contactRequest).ToString();

            SendContactRequestToNeal(contactRequest);
            SentEmailToContactRequestor(contactRequest);

            return PartialView(contactRequest);
        }

        public ActionResult ContactResponse(ContactRequest contactRequest) => PartialView(contactRequest);

        private bool SendContactRequestToNeal(ContactRequest contactRequest)
            => EmailFactory.CreateEmailService().Send(EmailFactory.CreateEmailMessageToNeal(contactRequest));
       
        private bool SentEmailToContactRequestor(ContactRequest contactRequest)
            => EmailFactory.CreateEmailService().Send(EmailFactory.CreateEmailMessageToContact(contactRequest));
        
    }
}