﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// Information decoded from well-known custom attributes applied on a property.
    /// </summary>
    internal sealed class PropertyWellKnownAttributeData : CommonPropertyWellKnownAttributeData
    {
        #region SkipLocalsInitAttribute
        private bool _hasSkipLocalsInitAttribute;
        public bool HasSkipLocalsInitAttribute
        {
            get
            {
                VerifySealed(expected: true);
                return _hasSkipLocalsInitAttribute;
            }
            set
            {
                VerifySealed(expected: false);
                _hasSkipLocalsInitAttribute = value;
                SetDataStored();
            }
        }
        #endregion
    }
}
