using System;
using System.Data;

using CMS.Base;
using CMS.DataEngine;
using CMS.Helpers;

namespace DoctorList
{
    /// <summary>
    /// Class providing <see cref="AppointmentInfo"/> management.
    /// </summary>
    [ProviderInterface(typeof(IAppointmentInfoProvider))]
    public partial class AppointmentInfoProvider : AbstractInfoProvider<AppointmentInfo, AppointmentInfoProvider>, IAppointmentInfoProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentInfoProvider"/> class.
        /// </summary>
        public AppointmentInfoProvider()
            : base(AppointmentInfo.TYPEINFO)
        {
        }

        /// <summary>
        /// Returns a query for all the <see cref="AppointmentInfo"/> objects.
        /// </summary>
        public static ObjectQuery<AppointmentInfo> GetAppointments()
        {
            return ProviderObject.GetObjectQuery();
        }


        /// <summary>
        /// Returns <see cref="AppointmentInfo"/> with specified ID.
        /// </summary>
        /// <param name="id"><see cref="AppointmentInfo"/> ID.</param>
        public static AppointmentInfo GetAppointmentInfo(int id)
        {
            return ProviderObject.GetInfoById(id);
        }


        /// <summary>
        /// Sets (updates or inserts) specified <see cref="AppointmentInfo"/>.
        /// </summary>
        /// <param name="infoObj"><see cref="AppointmentInfo"/> to be set.</param>
        public static void SetAppointmentInfo(AppointmentInfo infoObj)
        {
            ProviderObject.SetInfo(infoObj);
        }


        /// <summary>
        /// Deletes specified <see cref="AppointmentInfo"/>.
        /// </summary>
        /// <param name="infoObj"><see cref="AppointmentInfo"/> to be deleted.</param>
        public static void DeleteAppointmentInfo(AppointmentInfo infoObj)
        {
            ProviderObject.DeleteInfo(infoObj);
        }


        /// <summary>
        /// Deletes <see cref="AppointmentInfo"/> with specified ID.
        /// </summary>
        /// <param name="id"><see cref="AppointmentInfo"/> ID.</param>
        public static void DeleteAppointmentInfo(int id)
        {
            AppointmentInfo infoObj = GetAppointmentInfo(id);
            DeleteAppointmentInfo(infoObj);
        }
    }
}