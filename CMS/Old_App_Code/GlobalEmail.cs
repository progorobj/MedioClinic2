using CMS;
using CMS.DataEngine;
using CMS.EmailEngine;
using CMS.Membership;
using CMSApp;
using DoctorList;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;


[assembly:RegisterModule(typeof(GlobalEmail))]
namespace CMSApp
{
    public class GlobalEmail : Module
    {

        public GlobalEmail():base("GlobalEmail")
        {
        }


        protected override void OnInit()
        {
            base.OnInit();


            AppointmentInfo.TYPEINFO.Events.Insert.After += Insert_After;
        }

        /*void Insert_After(object sender, ObjectEventArgs e)
        {
            var user = e.Object as UserInfo;

            if (user !=null)
            {
                var email = new EmailMessage()
                {
                    Recipients = "admin@learn.Kentico.local",
                    From = "no-reply@learn.Kentico.local",
                    Subject = String.Format("User {0} was created", user.UserName),
                    PlainTextBody = "New user was created"

                };

                EmailSender.SendEmail(email);

            }
        }*/


        void Insert_After(object sender, ObjectEventArgs e)
        {
            var appointment = e.Object as AppointmentInfo;

            string email = "";

            ObjectQuery<DoctorInfo> listdoc = DoctorInfoProvider.GetDoctors();
            foreach (var item in listdoc)
            {
                if(item.DoctorID==appointment.DoctorID)
                {
                    email = item.DoctorEmail;
                }
            }



          if (appointment != null)
          {
              var unemail = new EmailMessage()
              {
                  Recipients = "zied@yahoo.fr",
                  From = "no-reply@learn.Kentico.local",
                  Subject = String.Format($"nom du patient{appointment.AppointmentPatientFirstName} {appointment.AppointmentPatientLastName} , date du RDV {appointment.AppointmentDate} , {email} "),
                  PlainTextBody = "un nouveau rendez-vous est enregistré"

              };

              EmailSender.SendEmail(unemail);

          }
      }


    }
}