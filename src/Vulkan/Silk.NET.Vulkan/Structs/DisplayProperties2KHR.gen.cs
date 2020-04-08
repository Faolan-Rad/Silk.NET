// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct DisplayProperties2KHR
    {
        public DisplayProperties2KHR
        (
            StructureType sType = StructureType.DisplayProperties2Khr,
            void* pNext = default,
            DisplayPropertiesKHR displayProperties = default
        )
        {
           SType = sType;
           PNext = pNext;
           DisplayProperties = displayProperties;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DisplayPropertiesKHR DisplayProperties;
    }
}