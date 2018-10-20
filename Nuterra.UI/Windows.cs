using UnityEngine;

namespace Nuterra.UI
{
    public class Windows
    {
        public GUIStyle Default { get; set; }

        internal Windows()
        {
            Default = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Border_BG.png"),
                    textColor = Color.white
                },
                alignment = TextAnchor.UpperCenter,
                border = new RectOffset(16, 16, 16, 16),
                padding = new RectOffset(16, 16, 26, 16),
                contentOffset = new Vector2(0f,-18f),
            };
        }
    }
}
