using UnityEngine;

namespace Nuterra.UI
{
    public class Buttons
    {
        public GUIStyle HUDDefault { get; set; }

        public GUIStyle HUDRed { get; set; }

        public GUIStyle Close { get; set; }

        public GUIStyle Plain { get; set; }

        public GUIStyle PlainGrey { get; set; }

        internal Buttons()
        {
            HUDDefault = new GUIStyle(GUI.skin.button)
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_BG.png"),
                    textColor = Color.white
                },
                hover =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_Highlight.png"),
                    textColor = Color.white
                },
                active =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_Selected.png"),
                    textColor = Color.white
                },
                onNormal =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_Selected.png"),
                    textColor = Color.white
                },
                onHover =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_Highlight.png"),
                    textColor = Color.white
                },
                onActive =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_BG.png"),
                    textColor = Color.white
                },
                border = new RectOffset(10, 10, 10, 10),
                padding = new RectOffset(5, 5, 5, 5),
                alignment = TextAnchor.MiddleCenter,
                
                
            };

            HUDRed = new GUIStyle(HUDDefault)
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_GREY_BG.png"),
                    textColor = Color.white
                },
                hover =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_RED_BG.png"),
                    textColor = Color.white
                },
                active =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_RED_BG.png"),
                    textColor = Color.white
                },
                onNormal =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_RED_BG.png"),
                    textColor = Color.white
                },
                onHover =
                {
                    background = Elements.LoadImageFromFile("HUD_Button_RED_BG.png"),
                    textColor = Color.white
                }
            };

            Close = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Button_Close.png")
                },
                active =
                {
                    background = Elements.LoadImageFromFile("Button_Close.png")
                },
                onNormal =
                {
                    background = Elements.LoadImageFromFile("Button_Close.png")
                },
                alignment = TextAnchor.UpperRight,
                margin = new RectOffset { right = 0, top=0 }
            };

            Plain = new GUIStyle(HUDDefault)
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Button_BG.png")
                },
                hover =
                {
                    background = Elements.LoadImageFromFile("Button_BG.png")
                },
                active =
                {
                    background = Elements.LoadImageFromFile("Button_Highlight_BG.png")
                },
                onNormal =
                {
                    background = Elements.LoadImageFromFile("Button_Highlight_BG.png")
                },
                onHover =
                {
                    background = Elements.LoadImageFromFile("Button_BG.png")
                },
                onActive =
                {
                    background = Elements.LoadImageFromFile("Button_BG.png")
                }
            };

            PlainGrey = new GUIStyle(Plain)
            {
                normal =
                {
                    background = Elements.LoadImageFromFile("Button_GREY_BG.png")
                },
                hover =
                {
                    background = Elements.LoadImageFromFile("Button_GREY_BG.png")
                },
            };
        }
    }
}
