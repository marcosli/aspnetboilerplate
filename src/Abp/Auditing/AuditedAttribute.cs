﻿using System;

namespace Abp.Auditing
{
    /// <summary>
    /// This attribute is used to apply audit logging for a single method or
    /// all methods of a class or interface.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface  | AttributeTargets.Method)]
    public class AuditedAttribute : Attribute
    {

    }
}
