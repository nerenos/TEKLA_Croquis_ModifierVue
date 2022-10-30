#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace UserMacros {
    public sealed class Macro {
        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]
        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime) {
            Tekla.Macros.Akit.IAkitScriptHost akit = runtime.Get<Tekla.Macros.Akit.IAkitScriptHost>();
            akit.CommandStart("ail_create_dimension", "free", "main_frame");
            akit.CommandEnd();
            akit.CommandStart("ail_create_dimension", "free", "main_frame");
            akit.PushButton("dim_on_off", "dim_dial");
            akit.ValueChange("dim_dial", "ShortExtensionLine", "1");
            akit.CommandEnd();
            akit.PushButton("dim_modify", "dim_dial");
            akit.PushButton("dim_apply", "dim_dial");
            akit.PushButton("dim_ok", "dim_dial");
        }
    }
}
