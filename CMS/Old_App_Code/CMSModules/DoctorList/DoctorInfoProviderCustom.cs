using DoctorList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorList
{
    /// <summary>
    /// Class providing <see cref="DoctorInfo"/> management.
    /// </summary>
    public partial class DoctorInfoProvider
    {
        /// <summary>
        /// Inserts / Updates list of DoctorInfos.
        /// </summary>
        /// <param name="doctors">List of DoctorInfos</param>
        public static int SetDoctors(List<DoctorInfo> doctors)
        {
            int count = 0;

            foreach (DoctorInfo doctor in doctors)
            {
                DoctorInfo doc = DoctorInfoProvider.GetDoctorInfo(doctor.DoctorCodeName);

                if (doc == null)
                {
                    DoctorInfoProvider.SetDoctorInfo(doctor);
                }
                else
                {
                    doc.DoctorFirstName = doctor.DoctorFirstName;
                    doc.DoctorLastName = doctor.DoctorLastName;
                    doc.DoctorEmail = doctor.DoctorEmail;
                    doc.DoctorLastModified = DateTime.Now;
                    DoctorInfoProvider.SetDoctorInfo(doc);
                    count++;
                }
            }

            return count;
        }
    }
}