using CMS.DataEngine;

namespace DoctorList
{
    /// <summary>
    /// Class providing <see cref="DoctorInfo"/> management.
    /// </summary>
    [ProviderInterface(typeof(IDoctorInfoProvider))]
    public partial class DoctorInfoProvider : AbstractInfoProvider<DoctorInfo, DoctorInfoProvider>, IDoctorInfoProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoctorInfoProvider"/> class.
        /// </summary>
        public DoctorInfoProvider()
            : base(DoctorInfo.TYPEINFO)
        {
        }
    }
}