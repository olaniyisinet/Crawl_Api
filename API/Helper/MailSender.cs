using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace API.Helper
{
	public class MailSender
	{
		public static string sendRegistrationEmail()
		{
			string status = "";

			SmtpClient client = new SmtpClient();
			client.Port = 587;
			client.Host = "smtp.gmail.com";
			client.EnableSsl = true;
			client.Timeout = 10000;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			client.Credentials = new System.Net.NetworkCredential("olaniyiolatunji@gmail.com", "@123");

			MailMessage mm = new MailMessage("donotreply@domain.com", "sendtomyemail@domain.co.uk", "test", "test");
			mm.BodyEncoding = UTF8Encoding.UTF8;
			mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

		//	client.Send(mm);

			try
			{
				client.Send(mm);
				status = "Email Sent";
			}
			catch
			{
				status = "failed";
			}
			return status;
		}

	}
}