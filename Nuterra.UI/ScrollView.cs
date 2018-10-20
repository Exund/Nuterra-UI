using UnityEngine;

namespace Nuterra.UI
{
    public class ScrollView
    {
        public GUIStyle Horizontal { get; set; }

        public GUIStyle Vertical { get; set; }

        public GUIStyle ThumbVertical { get; set; }

        public GUIStyle ThumbHorizontal { get; set; }

        internal ScrollView()
        {
            this.Horizontal = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Scroll_Horizontal_BG.png")
                },
                fixedHeight = 16f,
                border = new RectOffset(8, 8, 8, 8)
            };
            this.Vertical = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Scroll_Vertical_BG.png")
                },
                fixedWidth = 16f,
                border = new RectOffset(8, 8, 8, 8)
            };
            this.ThumbHorizontal = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Scroll_Horizontal_Thumb.png")
                },
                fixedHeight = 16f,
                border = new RectOffset(8, 8, 8, 8)
            };
            this.ThumbVertical = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Scroll_Vertical_Thumb.png")
                },
                fixedWidth = 16f,
                border = new RectOffset(8, 8, 8, 8)
            };
        }
    }
}
