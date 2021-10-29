using CMS.DataEngine;

namespace DoctorList
{
    /// <summary>
    /// Declares members for <see cref="DoctorInfo"/> management.
    /// </summary>
    public partial interface IDoctorInfoProvider : IInfoProvider<DoctorInfo>, IInfoByIdProvider<DoctorInfo>, IInfoByNameProvider<DoctorInfo>
    {
    }
}