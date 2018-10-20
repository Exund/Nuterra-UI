using System;
using UnityEngine;

namespace Nuterra.UI
{
    public static class NuterraGUI
    {

        public static GUISkin Skin
        {
            get
            {
                return _skin;
            }
            set { _skin = value; }
        }

        static NuterraGUI()
        {
            try
            {
                //Debug.Log(System.Reflection.Assembly.GetExecutingAssembly().Location);

                Skin = GameObject.Instantiate(GUI.skin);
                Skin.window = Elements.Windows.Default;
                Skin.button = Elements.Buttons.HUDDefault;
                Skin.toggle = Elements.Toggle.Default;

                Skin.verticalScrollbar = Elements.ScrollView.Vertical;
                Skin.verticalScrollbarThumb = Elements.ScrollView.ThumbVertical;
                Skin.horizontalScrollbar = Elements.ScrollView.Horizontal;
                Skin.horizontalScrollbarThumb = Elements.ScrollView.ThumbHorizontal;

                Skin.textField = (Skin.textArea = Elements.InputFields.Default);

                Skin.label.fontSize = 12;
                Skin.label.margin = new RectOffset { top = 0, bottom = 0 };
                Skin.label.padding = new RectOffset { top = 0, bottom = 0 };


                var fonts = Resources.FindObjectsOfTypeAll<Font>();
                foreach (Font font in fonts)
                {
                    if (font.name == "Exo-Bold") Skin.font = font;
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static float NumberField(float value,float interval)
        {
            GUILayout.BeginHorizontal(GUILayout.Height(30));
            float.TryParse(GUILayout.TextField(value.ToString()), out float val);
            if (GUILayout.Button("+")) val += interval;
            if (GUILayout.Button("-")) val -= interval;
            GUILayout.EndHorizontal();
            return val;
        }

        private static GUISkin _skin;
    }
}
