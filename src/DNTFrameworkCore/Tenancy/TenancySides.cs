﻿using System;

namespace DNTFrameworkCore.Tenancy
{
    /// <summary>
    /// Represents sides in a multi tenancy application.
    /// </summary>
    [Flags]
    public enum TenancySides
    {
        None = 0,

        /// <summary>
        /// Tenant side.
        /// </summary>
        Tenant = 1 << 0,

        /// <summary>
        /// Host (tenancy owner) side.
        /// </summary>
        Host = 1 << 1
    }
}