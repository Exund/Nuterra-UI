using UnityEngine;

namespace Nuterra.UI
{
    public class Sliders
    {
        public GUIStyle Horizontal { get; set; }

        public GUIStyle Vertical { get; set; }

        public GUIStyle ThumbVertical { get; set; }

        public GUIStyle ThumbHorizontal { get; set; }

        internal Sliders()
        {
            this.Horizontal = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Slider_BG.png")
                },
                onNormal =
                {
                    background = Elements.LoadImageFromFile("Slider_Highlight_BG.png")
                },
                active =
                {
                    background = Elements.LoadImageFromFile("Slider_Highlight_BG.png")
                },
                fixedHeight = 16f,
                border = new RectOffset(8, 8, 8, 8),
                padding = new RectOffset(0, 0, 0, 0),
                clipping = TextClipping.Clip,
            };
            this.Vertical = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Slider_BG.png")
                },
                onNormal =
                {
                    background = Elements.LoadImageFromFile("Slider_Highlight_BG.png")
                },
                active =
                {
                    background = Elements.LoadImageFromFile("Slider_Highlight_BG.png")
                },
                fixedWidth = 16f,
                border = new RectOffset(8, 8, 8, 8),
                padding = new RectOffset(0, 0, 0, 0),
                clipping = TextClipping.Clip,
                imagePosition = ImagePosition.TextOnly
            };
            this.ThumbHorizontal = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Slider_Fill_BG.png")
                },
                fixedHeight = 16f,
                fixedWidth = 20f,

                border = new RectOffset(5, 5, 5, 5),
                //test
                //padding = new RectOffset(0, 10, 0, 0)
            };
            this.ThumbVertical = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Slider_Fill_BG.png")
                },
                fixedWidth = 16f,
                fixedHeight = 20f,

                border = new RectOffset(5, 5, 5, 5),
                //test
                //padding = new RectOffset(0, 0, 10, 0)
            };
        }
    }
}
