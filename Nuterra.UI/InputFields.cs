using UnityEngine;

namespace Nuterra.UI
{
    public class InputFields
    {
        public GUIStyle Default { get; set; }

        internal InputFields()
        {
            this.Default = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("TextField_BG.png"),
                    textColor = Color.white
                },
                active =
                {
                    background = Elements.LoadImageFromFile("TextField_BG_Highlight.png"),
                    textColor = Color.white
                },

                clipping = TextClipping.Clip,
                border = new RectOffset(10, 10, 5, 5),
                overflow = new RectOffset(0, 0, 2, 2),
                alignment = TextAnchor.MiddleLeft,
                padding = new RectOffset(10, 10, 0, 0)
            };
        }
    }
}
