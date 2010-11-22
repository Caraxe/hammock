﻿using System;
using System.Runtime.Serialization;

namespace Hammock.Tasks
{
#if !SILVERLIGHT
    [Serializable]
#endif
    public enum RateLimitType
    {
#if !SILVERLIGHT && !Smartphone && !ClientProfiles && !NET20
        [EnumMember] ByPercent,
        [EnumMember] ByPredicate
#else
        ByPercent,
        ByPredicate
#endif
    }
}