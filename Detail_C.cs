// Generated by Tekla.Technology.Akit.ScriptBuilder



namespace Tekla.Technology.Akit.UserScript
{
    public class Script
    {
        public static void Run(Tekla.Technology.Akit.IScript akit)
        {
            akit.Callback("acmd_display_selected_drawing_object_dialog", "", "View_10 window_1");
            akit.ValueChange("view_dial", "gr_view_get_menu", "PP_Detail");
            akit.PushButton("view_apply", "view_dial");
            akit.PushButton("view_modify", "view_dial");
            akit.PushButton("view_ok", "view_dial");
        }
    }
}
