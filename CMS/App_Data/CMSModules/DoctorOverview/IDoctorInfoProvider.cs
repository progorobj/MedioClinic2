using CMS.DataEngine;

namespace DoctorOverview
{
    /// <summary>
    /// Declares members for <see cref="DoctorInfo"/> management.
    /// </summary>
    public partial interface IDoctorInfoProvider : IInfoProvider<DoctorInfo>, IInfoByIdProvider<DoctorInfo>, IInfoByNameProvider<DoctorInfo>
    {
    }
}