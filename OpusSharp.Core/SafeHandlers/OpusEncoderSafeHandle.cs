﻿using System.Runtime.InteropServices;
using System;
using System.Runtime.ConstrainedExecution;

namespace OpusSharp.Core.SafeHandlers
{
    internal class OpusEncoderSafeHandle : SafeHandle
    {
        public OpusEncoderSafeHandle(): base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            NativeOpus.opus_encoder_destroy(handle);
            return true;
        }
    }
}
