using System;
using System.Linq;
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

        public static void CreateGUIObject()
        {
            new GameObject().AddComponent<GUIOverride>();
        }

        static void ModifyGUI(GUISkin Default)
        {
            try
            {
                //Debug.Log(System.Reflection.Assembly.GetExecutingAssembly().Location);
                if (Skin != null)
                    return;
                Skin = Default;
                Skin.window = Elements.Windows.Default;
                Skin.button = Elements.Buttons.HUDDefault;
                Skin.toggle = Elements.Toggle.Default;

                Skin.verticalScrollbar = Elements.ScrollView.Vertical;
                Skin.verticalScrollbarThumb = Elements.ScrollView.ThumbVertical;
                Skin.horizontalScrollbar = Elements.ScrollView.Horizontal;
                Skin.horizontalScrollbarThumb = Elements.ScrollView.ThumbHorizontal;

                Skin.verticalSlider = Elements.Sliders.Vertical;
                Skin.verticalSliderThumb = Elements.Sliders.ThumbVertical;
                Skin.horizontalSlider = Elements.Sliders.Horizontal;
                Skin.horizontalSliderThumb = Elements.Sliders.ThumbHorizontal;

                Skin.textField = (Skin.textArea = Elements.InputFields.Default);

                Skin.label.fontSize = 12;
                Skin.label.margin = new RectOffset { top = 0, bottom = 0 };
                Skin.label.padding = new RectOffset { top = 0, bottom = 0 };

                var fonts = Resources.FindObjectsOfTypeAll<Font>();
                foreach (Font font in fonts)
                {
                    if (font.name == "Exo-Bold") Skin.font = font;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public class GUIOverride : MonoBehaviour
        {
            bool destroy;
            bool toggl;
            void OnGUI()
            {
                NuterraGUI.ModifyGUI(GUI.skin);
                GUI.Label(new Rect(0, 0, 100, 30), "Loaded GUI");
                if (!destroy)
                {
                    GameObject.Destroy(this, 5f);
                    destroy = true;
                }
            }
        }

        public static float NumberField(float value, float interval)
        {
            GUILayout.BeginHorizontal(GUILayout.Height(30));
            float.TryParse(GUILayout.TextField(value.ToString()), out float val);
            if (GUILayout.Button("+")) val += interval;
            if (GUILayout.Button("-")) val -= interval;
            GUILayout.EndHorizontal();
            var rounding = 0;
            var parts = interval.ToString().Split('.');
            if (parts.Length > 1) rounding = parts.Last().Length;
            return (float)Math.Round(val, rounding);
        }

        private static GUISkin _skin;
    }
}
