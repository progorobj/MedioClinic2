using System;
using System.Data;
using System.Runtime.Serialization;

using CMS;
using CMS.DataEngine;
using CMS.Helpers;
using DoctorOverview;

[assembly: RegisterObjectType(typeof(DoctorInfo), DoctorInfo.OBJECT_TYPE)]

namespace DoctorOverview
{
    /// <summary>
    /// Data container class for <see cref="DoctorInfo"/>.
    /// </summary>
    [Serializable]
    public partial class DoctorInfo : AbstractInfo<DoctorInfo, IDoctorInfoProvider>
    {
        /// <summary>
        /// Object type.
        /// </summary>
        public const string OBJECT_TYPE = "doctoroverview.doctor";


        /// <summary>
        /// Type information.
        /// </summary>
#warning "You will need to configure the type info."
        public static readonly ObjectTypeInfo TYPEINFO = new ObjectTypeInfo(typeof(DoctorInfoProvider), OBJECT_TYPE, "DoctorOverview.Doctor", "DoctorID", "DoctorLastModified", "DoctorGuid", "DoctorCodeName", "DoctorCodeName", null, null, null, null)
        {
            ModuleName = "DoctorOverview",
            TouchCacheDependencies = true,
        };


        /// <summary>
        /// Doctor ID.
        /// </summary>
        [DatabaseField]
        public virtual int DoctorID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("DoctorID"), 0);
            }
            set
            {
                SetValue("DoctorID", value);
            }
        }


        /// <summary>
        /// Doctor guid.
        /// </summary>
        [DatabaseField]
        public virtual Guid DoctorGuid
        {
            get
            {
                return ValidationHelper.GetGuid(GetValue("DoctorGuid"), Guid.Empty);
            }
            set
            {
                SetValue("DoctorGuid", value);
            }
        }


        /// <summary>
        /// Doctor code name.
        /// </summary>
        [DatabaseField]
        public virtual string DoctorCodeName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("DoctorCodeName"), String.Empty);
            }
            set
            {
                SetValue("DoctorCodeName", value);
            }
        }


        /// <summary>
        /// Doctor first name.
        /// </summary>
        [DatabaseField]
        public virtual string DoctorFirstName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("DoctorFirstName"), String.Empty);
            }
            set
            {
                SetValue("DoctorFirstName", value);
            }
        }


        /// <summary>
        /// Doctor last name.
        /// </summary>
        [DatabaseField]
        public virtual string DoctorLastName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("DoctorLastName"), String.Empty);
            }
            set
            {
                SetValue("DoctorLastName", value);
            }
        }


        /// <summary>
        /// Doctor specialty.
        /// </summary>
        [DatabaseField]
        public virtual string DoctorSpecialty
        {
            get
            {
                return ValidationHelper.GetString(GetValue("DoctorSpecialty"), String.Empty);
            }
            set
            {
                SetValue("DoctorSpecialty", value);
            }
        }


        /// <summary>
        /// Doctor email.
        /// </summary>
        [DatabaseField]
        public virtual string DoctorEmail
        {
            get
            {
                return ValidationHelper.GetString(GetValue("DoctorEmail"), String.Empty);
            }
            set
            {
                SetValue("DoctorEmail", value);
            }
        }


        /// <summary>
        /// Doctor last modified.
        /// </summary>
        [DatabaseField]
        public virtual DateTime DoctorLastModified
        {
            get
            {
                return ValidationHelper.GetDateTime(GetValue("DoctorLastModified"), DateTimeHelper.ZERO_TIME);
            }
            set
            {
                SetValue("DoctorLastModified", value);
            }
        }


        /// <summary>
        /// Deletes the object using appropriate provider.
        /// </summary>
        protected override void DeleteObject()
        {
            Provider.Delete(this);
        }


        /// <summary>
        /// Updates the object using appropriate provider.
        /// </summary>
        protected override void SetObject()
        {
            Provider.Set(this);
        }


        /// <summary>
        /// Constructor for de-serialization.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected DoctorInfo(SerializationInfo info, StreamingContext context)
            : base(info, context, TYPEINFO)
        {
        }


        /// <summary>
        /// Creates an empty instance of the <see cref="DoctorInfo"/> class.
        /// </summary>
        public DoctorInfo()
            : base(TYPEINFO)
        {
        }


        /// <summary>
        /// Creates a new instances of the <see cref="DoctorInfo"/> class from the given <see cref="DataRow"/>.
        /// </summary>
        /// <param name="dr">DataRow with the object data.</param>
        public DoctorInfo(DataRow dr)
            : base(TYPEINFO, dr)
        {
        }
    }
}