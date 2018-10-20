using UnityEngine;

namespace Nuterra.UI
{
    public class Toggle
    {
        public GUIStyle Default { get; set; }

        public GUIStyle Check { get; set; }

        internal Toggle()
        {
            Default = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Toggle_OFF.png")
                },
                active =
                {
                    background = Elements.LoadImageFromFile("Toggle_ON.png")
                },
            };
            Check = new GUIStyle(GUI.skin.toggle)
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Check_Unticked.png")
                },
                active =
                {
                    background = Elements.LoadImageFromFile("Check_Ticked.png")
                },
                border = new RectOffset(2, 2, 2, 2)
            };
        }
    }
}
