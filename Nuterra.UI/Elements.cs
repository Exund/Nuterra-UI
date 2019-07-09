using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Nuterra.UI
{
    public class Elements
    {
        public static bool IsInitialized { get; private set; } = false;

        public static Windows Windows { get; private set; }

        public static Buttons Buttons { get; private set; }

        public static Toggle Toggle { get; private set; }

        public static ScrollView ScrollView { get; private set; }

        public static InputFields InputFields { get; private set; }

        public static Sliders Sliders { get; private set; }

        static Elements()
        {
            try
            {
                Windows = new Windows();
                Buttons = new Buttons();
                Toggle = new Toggle();
                ScrollView = new ScrollView();
                InputFields = new InputFields();
                Sliders = new Sliders();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static Texture2D LoadImageFromAsset(string name)
        {
            return LoadImageFromFile(name);
        }

        public static Texture2D LoadImageFromFile(string name)
        {
            if (loadedTextures.ContainsKey(name))
            {
                Texture2D texture2D;
                loadedTextures.TryGetValue(name, out texture2D);
                if (texture2D != null)
                {
                    return texture2D;
                }
            }
            Texture2D result;
            try
            {
                Texture2D texture2D2 = new Texture2D(0, 0);
                string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
				var index = location.LastIndexOf("\\");
				if(index == -1) index = location.LastIndexOf("/");
				location = location.Remove(index);
                texture2D2.LoadImage(File.ReadAllBytes(Path.Combine(location+"/UI", name)));
                loadedTextures.Add(name, texture2D2);
                result = texture2D2;
            }
            catch (Exception ex)
            {
                Debug.LogWarning("Failed to load: " + name);
                Debug.LogException(ex);
                result = null;
            }
            return result;
        }
        private static readonly Dictionary<string, Texture2D> loadedTextures = new Dictionary<string, Texture2D>();
    }
}
