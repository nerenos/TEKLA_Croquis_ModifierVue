﻿#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Wpf.Runtime"
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace UserMacros {
    public sealed class Macro {
        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]
        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime) {
            Tekla.Macros.Akit.IAkitScriptHost akit = runtime.Get<Tekla.Macros.Akit.IAkitScriptHost>();
            Tekla.Macros.Wpf.Runtime.IWpfMacroHost wpf = runtime.Get<Tekla.Macros.Wpf.Runtime.IWpfMacroHost>();
            wpf.InvokeCommand("CommandRepository", "Dimensions.CreateFree");
            wpf.InvokeCommand("CommandRepository", "Dimensions.CreateFree");
            akit.ValueChange("dim_dial", "dim_precision", "1");
            akit.ValueChange("dim_dial", "dim_format", "0");
            akit.PushButton("dim_apply", "dim_dial");
            akit.PushButton("dim_ok", "dim_dial");
        }
    }
}
