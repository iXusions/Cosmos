﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.IL2CPU.X86.X {
    public class RegisterEBX : Register32 {
        public static readonly RegisterEBX Instance = new RegisterEBX();

        public static implicit operator RegisterEBX(ElementReference aReference) {
            Instance.Move(aReference);
            return Instance;
        }

        public static implicit operator RegisterEBX(MemoryAction aAction) {
            Instance.Move(aAction);
            return Instance;
        }

        public static implicit operator RegisterEBX(UInt32 aValue) {
            Instance.Move(aValue);
            return Instance;
        }

        public static implicit operator RegisterEBX(RegisterEAX aValue) {
            Instance.Move(aValue.GetId());
            return Instance;
        }

        public static implicit operator RegisterEBX(RegisterECX aValue) {
            Instance.Move(aValue.GetId());
            return Instance;
        }

        public static implicit operator RegisterEBX(RegisterEDX aValue) {
            Instance.Move(aValue.GetId());
            return Instance;
        }
    }
}
