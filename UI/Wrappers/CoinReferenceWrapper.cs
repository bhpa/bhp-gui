﻿using Bhp.Network.P2P.Payloads;
using System.ComponentModel;

namespace Bhp.UI.Wrappers
{
    internal class CoinReferenceWrapper
    {
        [TypeConverter(typeof(UIntBaseConverter))]
        public UInt256 PrevHash { get; set; }
        public ushort PrevIndex { get; set; }

        public CoinReference Unwrap()
        {
            return new CoinReference
            {
                PrevHash = PrevHash,
                PrevIndex = PrevIndex
            };
        }

        public static CoinReferenceWrapper Wrap(CoinReference reference)
        {
            return new CoinReferenceWrapper
            {
                PrevHash = reference.PrevHash,
                PrevIndex = reference.PrevIndex
            };
        }
    }
}
