#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace UserMacros {
    public sealed class Macro {
        [Tekla.Macros.Runtime.MacroEntryPointAttribute()]
        public static void Run(Tekla.Macros.Runtime.IMacroRuntime runtime) {
            Tekla.Macros.Akit.IAkitScriptHost akit = runtime.Get<Tekla.Macros.Akit.IAkitScriptHost>();
            akit.TableSelect("adraw_dial", "table_ViewsTable", new int[] {
                        1});
            akit.TableValueChange("adraw_dial", "table_ViewsTable", "col_ViewType", "1");
            akit.TableSelect("adraw_dial", "table_ViewsTable", new int[] {
                        2});
            akit.TableValueChange("adraw_dial", "table_ViewsTable", "col_ViewType", "2");
            akit.ModalDialog(1);
            akit.PushButton("gr_adraw_modify", "adraw_dial");
            akit.PushButton("gr_adraw_ok", "adraw_dial");
        }
    }
}
