using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Models.Profile
{
    public enum GetProfileResultState
    {
        UserNotFound,
        UserFound
    }

    public enum PostProfileResultState
    {
        UserNotFound,
        UserNotMapped,
        UserNotUpdated,
        UserUpdated
    }
}
