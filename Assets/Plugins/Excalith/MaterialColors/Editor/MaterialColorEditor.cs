using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Excalith.MaterialColors
{
    public class MaterialColorEditor : EditorWindow
    {
        #region Variables
        private int m_ColorSteps = 5;
        private MaterialColorType m_Filter = MaterialColorType.None;
        #endregion

        [MenuItem("Window/Tools/Material Colors")]
        public static void ShowWindow()
        {
            MaterialColorEditor window = EditorWindow.GetWindow<MaterialColorEditor>();

            Texture icon = EditorGUIUtility.FindTexture("ColorPicker.CycleSlider");

            GUIContent titleContent = new GUIContent("Colorizer", icon);
            window.titleContent = titleContent;
        }

        private void OnGUI()
        {
            bool isDefault = m_Filter == MaterialColorType.None;

            if (isDefault)
            {
                EditorGUILayout.BeginHorizontal();
                m_ColorSteps = EditorGUILayout.IntSlider("", m_ColorSteps, 0, 9);
                if (GUILayout.Button("Reset", GUILayout.Width(90f)))
                {
                    m_ColorSteps = 5;
                };
                EditorGUILayout.EndHorizontal();
            }
            else
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField(m_Filter.ToString(), EditorStyles.boldLabel, GUILayout.ExpandWidth(true));

                if (GUILayout.Button("Back", GUILayout.Width(90f)))
                {
                    m_Filter = MaterialColorType.None;
                };

                EditorGUILayout.EndHorizontal();
            }


            if (isDefault)
                DrawDefaultUI();
            else
                DrawSelectedUI(m_Filter);
        }

        private void DrawDefaultUI()
        {
            EditorGUILayout.BeginVertical();

            int counter = 0;
            EditorGUILayout.BeginHorizontal();
            foreach (KeyValuePair<MaterialColorType, List<Color32>> kvp in MaterialColor.Colors)
            {
                counter += 1;

                DrawColorButton(kvp.Key);

                if (counter == 5)
                {
                    counter = 0;
                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.BeginHorizontal();
                }
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndVertical();
        }

        private void DrawSelectedUI(MaterialColorType key)
        {
            EditorGUILayout.BeginVertical();

            int index = 0;
            int counter = 0;
            EditorGUILayout.BeginHorizontal();

            if (key != MaterialColorType.None)
            {
                foreach (Color32 col in MaterialColor.Colors[key])
                {
                    counter += 1;
                    index += 1;

                    DrawColorButton(key, index, col);

                    if (counter == 5)
                    {
                        counter = 0;
                        EditorGUILayout.EndHorizontal();
                        EditorGUILayout.BeginHorizontal();
                    }
                }
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndVertical();
        }


        private void DrawColorButton(MaterialColorType key)
        {
            Dictionary<MaterialColorType, List<Color32>> colors = MaterialColor.Colors;
            if (colors == null)
            {
                Debug.LogError("Colors is null");
                return;
            }
            Color32 color = colors[key][m_ColorSteps];
            if (GUILayout.Button("", GetBtnStyle(color), GUILayout.ExpandHeight(true)))
            {
                if (Event.current.button == 1)
                {
                    m_Filter = key;
                }
                else
                {
                    string title = "Copied " + key + "\n Variant " + m_ColorSteps;
                    Copy(color, title);
                }
            };
        }

        private void DrawColorButton(MaterialColorType key, int variant, Color32 color)
        {
            if (GUILayout.Button("", GetBtnStyle(color), GUILayout.ExpandHeight(true)))
            {
                string title = "Copied " + key + "\n Variant " + variant;
                Copy(color, title);
            };
        }


        private void DrawBackButton()
        {
            if (GUILayout.Button("", GetBtnStyle(Color.black), GUILayout.ExpandHeight(true)))
            {
                m_Filter = MaterialColorType.None;
            };
        }

        private void Copy(Color32 color, string title)
        {
            #if !PRE_UNITY_2019_1
                this.ShowNotification(new GUIContent(title));
            #else
                this.ShowNotification(new GUIContent(title), 0.5);
            #endif

            string hexValue = "#" + color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
            EditorGUIUtility.systemCopyBuffer = hexValue;
        }

        GUIStyle GetBtnStyle(Color32 color)
        {
            var s = new GUIStyle(GUI.skin.label);
            Color[] pix = new Color[] { color };
            Texture2D result = new Texture2D(1, 1);
            result.SetPixels(pix);
            result.Apply();
            s.normal.background = result;
            s.fontSize = 5;
            s.alignment = TextAnchor.MiddleCenter;
            s.margin = new RectOffset(0, 0, 0, 0);
            return s;
        }
    }
}