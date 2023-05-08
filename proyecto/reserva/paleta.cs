using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.reserva
{
    public class paleta : KryptonPalette
    {
        public static paleta p = new paleta();
        public static void set(KryptonForm f)
        {
            f.Palette = p;foreach (Control c in f.Controls)
            {
                if (c is KryptonButton b) b.Palette = p;
                if (c is KryptonTextBox t) t.Palette = p;
                //                if (c is ) t.Palette = p;
            }
            //return f;
        }
        public paleta()
        {
            // 
            // kryptonPalette1
            // 
            //this.backco
            this.ButtonSpecs.FormClose.Image = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_exit1;
            this.ButtonSpecs.FormMax.Image = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormMin.Image = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_minus;
            this.ButtonSpecs.FormRestore.Image = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImageCheckedNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImageCheckedPressed = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImageCheckedTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImageDisabled = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImageNormal = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::proyecto.Properties.Resources.bt_tikito;
            this.ButtonStyles.ButtonAlternate.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonStyles.ButtonButtonSpec.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.Yellow;
            this.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.Yellow;
            this.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonStyles.ButtonInputControl.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 35F;
            this.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 3;
            this.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DragDrop.SolidBorder = System.Drawing.Color.Lime;
            this.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.LemonChiffon;
            this.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.FormStyles.FormCommon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormStyles.FormCommon.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormStyles.FormCommon.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FormStyles.FormCommon.StateActive.Border.Rounding = 10F;
            this.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FormStyles.FormCommon.StateCommon.Border.Rounding = 10F;
            this.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Rounding = 5F;
            this.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.InputControlStyles.InputControlCommon.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InputControlStyles.InputControlCommon.StateActive.Border.Rounding = 10F;
            this.InputControlStyles.InputControlCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InputControlStyles.InputControlCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InputControlStyles.InputControlCommon.StateCommon.Border.Rounding = 5F;
            this.InputControlStyles.InputControlCommon.StateCommon.Border.Width = 4;
            this.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.LemonChiffon;
            this.Ribbon.RibbonGroupButtonText.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));

        }
    }
}
