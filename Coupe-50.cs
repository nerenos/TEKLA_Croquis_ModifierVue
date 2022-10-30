#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace UserMacros {
    public sealed class Macro {
        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]
        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime) {
            Tekla.Macros.Akit.IAkitScriptHost akit = runtime.Get<Tekla.Macros.Akit.IAkitScriptHost>();
            akit.Callback("acmd_display_selected_drawing_object_dialog", "", "View_10 window_1");
            akit.PushButton("view_on_off", "view_dial");
            akit.PushButton("view_on_off", "view_dial");
            akit.TabChange("view_dial", "tabWndViewAttributes", "tabAttributes2");
            akit.ValueChange("view_dial", "gr_view_cut_on", "1");
            akit.ValueChange("view_dial", "gr_view_cut_min_dist", "100.000000000000");
            akit.PushButton("view_modify", "view_dial");
            akit.PushButton("view_ok", "view_dial");
        }
    }
}
