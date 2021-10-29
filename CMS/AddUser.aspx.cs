using CMS.Membership;
using DoctorList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CMSApp
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /* DoctorInfo doctor1 = new DoctorInfo()
            {
                DoctorFirstName = "zakaria",
                DoctorLastName = "Hajji",
                DoctorEmail = "ziedhajji@gmail.com",
                DoctorCodeName = "5332456"
                
                

            };
            Console.WriteLine(doctor1.DoctorID);
            DoctorInfoProvider.SetDoctorInfo(doctor1);

            Response.Write(doctor1.DoctorFirstName + " " + doctor1.DoctorLastName + " was added. "+doctor1.DoctorID);*/


          /* AppointmentInfo appoi = new AppointmentInfo();
            appoi.AppointmentPatientEmail = "biri123@gotmail.fr";
            appoi.AppointmentPatientFirstName = "fizou";
            appoi.AppointmentPatientLastName = "rizou";
            appoi.AppointmentPatientPhoneNumber = "514-999-4489";
            appoi.AppointmentDate = DateTime.Today.Date;
            appoi.AppointmentPatientBirthDate = DateTime.Today.Date;
            appoi.AppointmentDoctorID = 10;

            AppointmentInfoProvider.SetAppointmentInfo(appoi);*/


            /*AppointmentInfo app = new AppointmentInfo();
            app.AppointmentPatientEmail = "birihajji@gotmail.fr";
            app.AppointmentPatientFirstName = "miri";
            app.AppointmentPatientLastName = "sisi";
            app.AppointmentPatientPhoneNumber = "514-999-8589";
            app.AppointmentDate = DateTime.Today.Date;
            app.AppointmentPatientBirthDate = DateTime.Today.Date;
            app.AppointmentDoctorID =10;

            AppointmentInfoProvider.SetAppointmentInfo(app);*/



            AppointmentInfo app = new AppointmentInfo();
            app.AppointmentPatientEmail = "justine@gotmail.fr";
            app.AppointmentPatientFirstName = "sikou";
            app.AppointmentPatientLastName = "birkou";
            app.AppointmentPatientPhoneNumber = "514-999-8589";
            app.AppointmentDate = DateTime.Today.Date;
            app.AppointmentPatientBirthDate = DateTime.Today.Date;
            app.AppointmentDoctorID = 10;

            AppointmentInfoProvider.SetAppointmentInfo(app);

        }





    }
}