using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;

using Tekla.Structures;
using TSM = Tekla.Structures.Model;
using TSD = Tekla.Structures.Drawing;
using TSDU = Tekla.Structures.Drawing.UI;
using Tekla.Structures.Model.Operations;

#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference "Tekla.Macros.Akit"
#pragma reference "Tekla.Macros.Wpf.Runtime"
#pragma reference "Tekla.Macros.Runtime"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace Tekla.Technology.Akit.UserScript {
    public sealed class Script {

        public static void Run(Tekla.Technology.Akit.IScript akit) {
			TSD.DrawingHandler drawingHandler = new TSD.DrawingHandler();

			
           foreach(TSD.DrawingObject drawingObject in drawingHandler.GetDrawingObjectSelector().GetSelected())
           {
                if(drawingObject is TSD.View)
				{
				    TSD.View SelectView = drawingObject as TSD.View;
					
					SelectView.Attributes.Scale = 5;
					SelectView.Modify();

				}
			}
			
        }
    }
}