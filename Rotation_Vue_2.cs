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
            akit.ValueChange("adraw_dial", "gr_dv_coord_sys_x_rotate", "0");
            akit.ValueChange("adraw_dial", "gr_dv_coord_sys_y_rotate", "0");
            akit.ValueChange("adraw_dial", "gr_dv_coord_sys_z_rotate", "180.000000000000");
            akit.ModalDialog(1);
            akit.PushButton("gr_adraw_modify", "adraw_dial");
            akit.PushButton("gr_adraw_ok", "adraw_dial");
        }
    }
}