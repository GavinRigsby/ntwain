﻿using NTwain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tester.WPF
{
    /// <summary>
    /// Wraps a capability as a view model.
    /// </summary>
    class CapVM
    {
        public CapabilityId Cap { get; set; }

        public string Name
        {
            get
            {
                if (Cap > CapabilityId.CustomBase)
                {
                    return "[Custom] " + ((int)Cap - (int)CapabilityId.CustomBase);
                }
                return Cap.ToString();
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
