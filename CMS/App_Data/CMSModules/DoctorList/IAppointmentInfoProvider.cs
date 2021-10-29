using CMS.DataEngine;

namespace DoctorList
{
    /// <summary>
    /// Declares members for <see cref="AppointmentInfo"/> management.
    /// </summary>
    public partial interface IAppointmentInfoProvider : IInfoProvider<AppointmentInfo>, IInfoByIdProvider<AppointmentInfo>, IInfoByNameProvider<AppointmentInfo>
    {
    }
}