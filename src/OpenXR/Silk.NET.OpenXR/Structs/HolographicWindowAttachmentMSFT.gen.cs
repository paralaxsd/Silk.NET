// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHolographicWindowAttachmentMSFT")]
    public unsafe partial struct HolographicWindowAttachmentMSFT
    {
        public HolographicWindowAttachmentMSFT
        (
            StructureType type = StructureType.TypeHolographicWindowAttachmentMsft,
            void* next = default,
            IntPtr holographicSpace = default,
            IntPtr coreWindow = default
        )
        {
            Type = type;
            Next = next;
            HolographicSpace = holographicSpace;
            CoreWindow = coreWindow;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "IUnknown*")]
        [NativeName("Type.Name", "IUnknown")]
        [NativeName("Name", "holographicSpace")]
        public IntPtr HolographicSpace;
/// <summary></summary>
        [NativeName("Type", "IUnknown*")]
        [NativeName("Type.Name", "IUnknown")]
        [NativeName("Name", "coreWindow")]
        public IntPtr CoreWindow;
    }
}
