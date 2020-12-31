// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L4635_C5")]
    public unsafe partial struct AnonymousRecordD3d11L4635C5
    {
        public AnonymousRecordD3d11L4635C5
        (
            BufferUav? buffer = null,
            Tex1DUav? texture1D = null,
            Tex1DArrayUav? texture1DArray = null,
            Tex2DUav? texture2D = null,
            Tex2DArrayUav? texture2DArray = null,
            Tex3DUav? texture3D = null
        ) : this()
        {
            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (texture1D is not null)
            {
                Texture1D = texture1D.Value;
            }

            if (texture1DArray is not null)
            {
                Texture1DArray = texture1DArray.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }

            if (texture3D is not null)
            {
                Texture3D = texture3D.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_BUFFER_UAV")]
        [NativeName("Type.Name", "D3D11_BUFFER_UAV")]
        [NativeName("Name", "Buffer")]
        public BufferUav Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_UAV")]
        [NativeName("Type.Name", "D3D11_TEX1D_UAV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DUav Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_ARRAY_UAV")]
        [NativeName("Type.Name", "D3D11_TEX1D_ARRAY_UAV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArrayUav Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_UAV")]
        [NativeName("Type.Name", "D3D11_TEX2D_UAV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DUav Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_ARRAY_UAV")]
        [NativeName("Type.Name", "D3D11_TEX2D_ARRAY_UAV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayUav Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX3D_UAV")]
        [NativeName("Type.Name", "D3D11_TEX3D_UAV")]
        [NativeName("Name", "Texture3D")]
        public Tex3DUav Texture3D;
    }
}