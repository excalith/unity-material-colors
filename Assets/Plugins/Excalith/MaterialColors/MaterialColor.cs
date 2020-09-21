using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Excalith.MaterialColors
{
    public enum MaterialColorType { None, Red, Pink, Purple, DeepPurple, Indigo, Blue, LightBlue, Cyan, Teal, Green, LightGreen, Lime, Yellow, Amber, Orange, DeepOrange, Brown, Grey, BlueGrey, Grayscale }
    public class MaterialColor
    {
        #region Private Variables
        private static MaterialColor _instance = new MaterialColor();
        public static Dictionary<MaterialColorType, List<Color32>> Colors { get; protected set; }
        public static List<Color32> RedVariations { get; protected set; }
        public static List<Color32> PinkVariations { get; protected set; }
        public static List<Color32> PurpleVariations { get; protected set; }
        public static List<Color32> DeepPurpleVariations { get; protected set; }
        public static List<Color32> IndigoVariations { get; protected set; }
        public static List<Color32> BlueVariations { get; protected set; }
        public static List<Color32> LightBlueVariations { get; protected set; }
        public static List<Color32> CyanVariations { get; protected set; }
        public static List<Color32> TealVariations { get; protected set; }
        public static List<Color32> GreenVariations { get; protected set; }
        public static List<Color32> LightGreenVariations { get; protected set; }
        public static List<Color32> LimeVariations { get; protected set; }
        public static List<Color32> YellowVariations { get; protected set; }
        public static List<Color32> AmberVariations { get; protected set; }
        public static List<Color32> OrangeVariations { get; protected set; }
        public static List<Color32> DeepOrangeVariations { get; protected set; }
        public static List<Color32> BrownVariations { get; protected set; }
        public static List<Color32> GreyVariations { get; protected set; }
        public static List<Color32> BlueGreyVariations { get; protected set; }
        public static List<Color32> GrayscaleVariations { get; protected set; }
        #endregion

        #region Constructor
        private MaterialColor()
        {
            RedVariations = new List<Color32>
            {
                new Color32(255, 235, 238, 255),
                new Color32(255, 205, 210, 255),
                new Color32(239, 154, 154, 255),
                new Color32(229, 115, 115, 255),
                new Color32(239, 83, 80, 255),
                new Color32(244, 67, 54, 255),
                new Color32(229, 57, 53, 255),
                new Color32(211, 47, 47, 255),
                new Color32(198, 40, 40, 255),
                new Color32(183, 28, 28, 255),
                new Color32(255, 138, 128, 255),
                new Color32(255, 82, 82, 255),
                new Color32(255, 23, 68, 255),
                new Color32(213, 0, 0, 255)
            };

            PinkVariations = new List<Color32>
            {
                new Color32(252, 228, 236, 255),
                new Color32(248, 187, 208, 255),
                new Color32(244, 143, 177, 255),
                new Color32(240, 98, 146, 255),
                new Color32(236, 64, 122, 255),
                new Color32(233, 30, 99, 255),
                new Color32(216, 27, 96, 255),
                new Color32(194, 24, 91, 255),
                new Color32(173, 20, 87, 255),
                new Color32(136, 14, 79, 255),
                new Color32(255, 128, 171, 255),
                new Color32(255, 64, 129, 255),
                new Color32(245, 0, 87, 255),
                new Color32(197, 17, 98, 255)
            };

            PurpleVariations = new List<Color32>
            {
                new Color32(243, 229, 245, 255),
                new Color32(225, 190, 231, 255),
                new Color32(206, 147, 216, 255),
                new Color32(186, 104, 200, 255),
                new Color32(171, 71, 188, 255),
                new Color32(156, 39, 176, 255),
                new Color32(142, 36, 170, 255),
                new Color32(123, 31, 162, 255),
                new Color32(106, 27, 154, 255),
                new Color32(74, 20, 140, 255),
                new Color32(234, 128, 252, 255),
                new Color32(224, 64, 251, 255),
                new Color32(213, 0, 249, 255),
                new Color32(170, 0, 255, 255)
            };

            DeepPurpleVariations = new List<Color32>
            {
                new Color32(237, 231, 246, 255),
                new Color32(209, 196, 233, 255),
                new Color32(179, 157, 219, 255),
                new Color32(149, 117, 205, 255),
                new Color32(126, 87, 194, 255),
                new Color32(103, 58, 183, 255),
                new Color32(94, 53, 177, 255),
                new Color32(81, 45, 168, 255),
                new Color32(69, 39, 160, 255),
                new Color32(49, 27, 146, 255),
                new Color32(179, 136, 255, 255),
                new Color32(124, 77, 255, 255),
                new Color32(101, 31, 255, 255),
                new Color32(98, 0, 234, 255)
            };

            IndigoVariations = new List<Color32>
            {
                new Color32(232, 234, 246, 255),
                new Color32(197, 202, 233, 255),
                new Color32(159, 168, 218, 255),
                new Color32(121, 134, 203, 255),
                new Color32(92, 107, 192, 255),
                new Color32(63, 81, 181, 255),
                new Color32(57, 73, 171, 255),
                new Color32(48, 63, 159, 255),
                new Color32(40, 53, 147, 255),
                new Color32(26, 35, 126, 255),
                new Color32(140, 158, 255, 255),
                new Color32(83, 109, 254, 255),
                new Color32(61, 90, 254, 255),
                new Color32(48, 79, 254, 255)
            };

            BlueVariations = new List<Color32>
            {
                new Color32(227, 242, 253, 255),
                new Color32(187, 222, 251, 255),
                new Color32(144, 202, 249, 255),
                new Color32(100, 181, 246, 255),
                new Color32(66, 165, 245, 255),
                new Color32(33, 150, 243, 255),
                new Color32(30, 136, 229, 255),
                new Color32(25, 118, 210, 255),
                new Color32(21, 101, 192, 255),
                new Color32(13, 71, 161, 255),
                new Color32(130, 177, 255, 255),
                new Color32(68, 138, 255, 255),
                new Color32(41, 121, 255, 255),
                new Color32(41, 98, 255, 255)
            };

            LightBlueVariations = new List<Color32>
            {
                new Color32(225, 245, 254, 255),
                new Color32(179, 229, 252, 255),
                new Color32(129, 212, 250, 255),
                new Color32(79, 195, 247, 255),
                new Color32(41, 182, 246, 255),
                new Color32(3, 169, 244, 255),
                new Color32(3, 155, 229, 255),
                new Color32(2, 136, 209, 255),
                new Color32(2, 119, 189, 255),
                new Color32(1, 87, 155, 255),
                new Color32(128, 216, 255, 255),
                new Color32(64, 196, 255, 255),
                new Color32(0, 176, 255, 255),
                new Color32(0, 145, 234, 255)
            };

            CyanVariations = new List<Color32>
            {
                new Color32(224, 247, 250, 255),
                new Color32(178, 235, 242, 255),
                new Color32(128, 222, 234, 255),
                new Color32(77, 208, 225, 255),
                new Color32(38, 198, 218, 255),
                new Color32(0, 188, 212, 255),
                new Color32(0, 172, 193, 255),
                new Color32(0, 151, 167, 255),
                new Color32(0, 131, 143, 255),
                new Color32(0, 96, 100, 255),
                new Color32(132, 255, 255, 255),
                new Color32(24, 255, 255, 255),
                new Color32(0, 229, 255, 255),
                new Color32(0, 184, 212, 255)
            };

            TealVariations = new List<Color32>
            {
                new Color32(224, 242, 241, 255),
                new Color32(178, 223, 219, 255),
                new Color32(128, 203, 196, 255),
                new Color32(77, 182, 172, 255),
                new Color32(38, 166, 154, 255),
                new Color32(0, 150, 136, 255),
                new Color32(0, 137, 123, 255),
                new Color32(0, 121, 107, 255),
                new Color32(0, 105, 92, 255),
                new Color32(0, 77, 64, 255),
                new Color32(167, 255, 235, 255),
                new Color32(100, 255, 218, 255),
                new Color32(29, 233, 182, 255),
                new Color32(0, 191, 165, 255)
            };

            GreenVariations = new List<Color32>
            {
                new Color32(232, 245, 233, 255),
                new Color32(200, 230, 201, 255),
                new Color32(165, 214, 167, 255),
                new Color32(129, 199, 132, 255),
                new Color32(102, 187, 106, 255),
                new Color32(76, 175, 80, 255),
                new Color32(67, 160, 71, 255),
                new Color32(56, 142, 60, 255),
                new Color32(46, 125, 50, 255),
                new Color32(27, 94, 32, 255),
                new Color32(185, 246, 202, 255),
                new Color32(105, 240, 174, 255),
                new Color32(0, 230, 118, 255),
                new Color32(0, 200, 83, 255)
            };

            LightGreenVariations = new List<Color32>
            {
                new Color32(241, 248, 233, 255),
                new Color32(220, 237, 200, 255),
                new Color32(197, 225, 165, 255),
                new Color32(174, 213, 129, 255),
                new Color32(156, 204, 101, 255),
                new Color32(139, 195, 74, 255),
                new Color32(124, 179, 66, 255),
                new Color32(104, 159, 56, 255),
                new Color32(85, 139, 47, 255),
                new Color32(51, 105, 30, 255),
                new Color32(204, 255, 144, 255),
                new Color32(178, 255, 89, 255),
                new Color32(118, 255, 3, 255),
                new Color32(100, 221, 23, 255)
            };

            LimeVariations = new List<Color32>
            {
                new Color32(249, 251, 231, 255),
                new Color32(240, 244, 195, 255),
                new Color32(230, 238, 156, 255),
                new Color32(220, 231, 117, 255),
                new Color32(212, 225, 87, 255),
                new Color32(205, 220, 57, 255),
                new Color32(192, 202, 51, 255),
                new Color32(175, 180, 43, 255),
                new Color32(158, 157, 36, 255),
                new Color32(130, 119, 23, 255),
                new Color32(244, 255, 129, 255),
                new Color32(238, 255, 65, 255),
                new Color32(198, 255, 0, 255),
                new Color32(174, 234, 0, 255)
            };

            YellowVariations = new List<Color32>
            {
                new Color32(255, 253, 231, 255),
                new Color32(255, 249, 196, 255),
                new Color32(255, 245, 157, 255),
                new Color32(255, 241, 118, 255),
                new Color32(255, 238, 88, 255),
                new Color32(255, 235, 59, 255),
                new Color32(253, 216, 53, 255),
                new Color32(251, 192, 45, 255),
                new Color32(249, 168, 37, 255),
                new Color32(245, 127, 23, 255),
                new Color32(255, 255, 141, 255),
                new Color32(255, 255, 0, 255),
                new Color32(255, 234, 0, 255),
                new Color32(255, 214, 0, 255)
            };

            AmberVariations = new List<Color32>
            {
                new Color32(255, 248, 225, 255),
                new Color32(255, 236, 179, 255),
                new Color32(255, 224, 130, 255),
                new Color32(255, 213, 79, 255),
                new Color32(255, 202, 40, 255),
                new Color32(255, 193, 7, 255),
                new Color32(255, 179, 0, 255),
                new Color32(255, 160, 0, 255),
                new Color32(255, 143, 0, 255),
                new Color32(255, 111, 0, 255),
                new Color32(255, 229, 127, 255),
                new Color32(255, 215, 64, 255),
                new Color32(255, 196, 0, 255),
                new Color32(255, 171, 0, 255)
            };

            OrangeVariations = new List<Color32>
            {
                new Color32(255, 243, 224, 255),
                new Color32(255, 224, 178, 255),
                new Color32(255, 204, 128, 255),
                new Color32(255, 183, 77, 255),
                new Color32(255, 167, 38, 255),
                new Color32(255, 152, 0, 255),
                new Color32(251, 140, 0, 255),
                new Color32(245, 124, 0, 255),
                new Color32(239, 108, 0, 255),
                new Color32(230, 81, 0, 255),
                new Color32(255, 209, 128, 255),
                new Color32(255, 171, 64, 255),
                new Color32(255, 145, 0, 255),
                new Color32(255, 109, 0, 255)
            };

            DeepOrangeVariations = new List<Color32>
            {
                new Color32(251, 233, 231, 255),
                new Color32(255, 204, 188, 255),
                new Color32(255, 171, 145, 255),
                new Color32(255, 138, 101, 255),
                new Color32(255, 112, 67, 255),
                new Color32(255, 87, 34, 255),
                new Color32(244, 81, 30, 255),
                new Color32(230, 74, 25, 255),
                new Color32(216, 67, 21, 255),
                new Color32(191, 54, 12, 255),
                new Color32(255, 158, 128, 255),
                new Color32(255, 110, 64, 255),
                new Color32(255, 61, 0, 255),
                new Color32(221, 44, 0, 255)
            };

            BrownVariations = new List<Color32>
            {
                new Color32(239, 235, 233, 255),
                new Color32(215, 204, 200, 255),
                new Color32(188, 170, 164, 255),
                new Color32(161, 136, 127, 255),
                new Color32(141, 110, 99, 255),
                new Color32(121, 85, 72, 255),
                new Color32(109, 76, 65, 255),
                new Color32(93, 64, 55, 255),
                new Color32(78, 52, 46, 255),
                new Color32(62, 39, 35, 255)
            };

            GreyVariations = new List<Color32>
            {
                new Color32(250, 250, 250, 255),
                new Color32(245, 245, 245, 255),
                new Color32(238, 238, 238, 255),
                new Color32(224, 224, 224, 255),
                new Color32(189, 189, 189, 255),
                new Color32(158, 158, 158, 255),
                new Color32(117, 117, 117, 255),
                new Color32(97, 97, 97, 255),
                new Color32(66, 66, 66, 255),
                new Color32(33, 33, 33, 255)
            };

            BlueGreyVariations = new List<Color32>
            {
                new Color32(236, 239, 241, 255),
                new Color32(207, 216, 220, 255),
                new Color32(176, 190, 197, 255),
                new Color32(144, 164, 174, 255),
                new Color32(120, 144, 156, 255),
                new Color32(96, 125, 139, 255),
                new Color32(84, 110, 122, 255),
                new Color32(69, 90, 100, 255),
                new Color32(55, 71, 79, 255),
                new Color32(38, 50, 56, 255)
            };

            GrayscaleVariations = new List<Color32>
            {
                new Color32(255, 255, 255, 255),
                new Color32(240, 240, 240, 255),
                new Color32(220, 220, 220, 255),
                new Color32(188, 188, 188, 255),
                new Color32(159, 159, 159, 255),
                new Color32(130, 130, 130,255),
                new Color32(100, 100, 100,255),
                new Color32(60, 60, 60,255),
                new Color32(30, 30, 30, 255),
                new Color32(0, 0, 0, 255)
            };

            MaterialColor.Colors = new Dictionary<MaterialColorType, List<Color32>>
            {
                { MaterialColorType.Red, RedVariations },
                { MaterialColorType.Pink, PinkVariations },
                { MaterialColorType.Purple, PurpleVariations },
                { MaterialColorType.DeepPurple, DeepPurpleVariations },
                { MaterialColorType.Indigo, IndigoVariations },
                { MaterialColorType.Blue, BlueVariations },
                { MaterialColorType.LightBlue, LightBlueVariations },
                { MaterialColorType.Cyan, CyanVariations },
                { MaterialColorType.Teal, TealVariations },
                { MaterialColorType.Green, GreenVariations },
                { MaterialColorType.LightGreen, LightGreenVariations },
                { MaterialColorType.Lime, LimeVariations },
                { MaterialColorType.Yellow, YellowVariations },
                { MaterialColorType.Amber, AmberVariations },
                { MaterialColorType.Orange, OrangeVariations },
                { MaterialColorType.DeepOrange, DeepOrangeVariations },
                { MaterialColorType.Brown, BrownVariations },
                { MaterialColorType.Grey, GreyVariations },
                { MaterialColorType.BlueGrey, BlueGreyVariations },
                { MaterialColorType.Grayscale, GrayscaleVariations }
            };
        }
        #endregion

        #region Color Functions
        /// <summary>
        /// Returns a red variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13) (between 0 and 13)</param>
        public static Color32 Red(int variation = 5)
        {
            CheckInstance();

            return RedVariations[variation];
        }

        /// <summary>
        /// Returns a pink variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Pink(int variation = 5)
        {
            CheckInstance();

            return PinkVariations[variation];
        }

        /// <summary>
        /// Returns a purple variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Purple(int variation = 5)
        {
            CheckInstance();

            return PurpleVariations[variation];
        }

        /// <summary>
        /// Returns a deep purple variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 DeepPurple(int variation = 5)
        {
            CheckInstance();

            return DeepPurpleVariations[variation];
        }

        /// <summary>
        /// Returns an indigo variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Indigo(int variation = 5)
        {
            CheckInstance();

            return IndigoVariations[variation];
        }

        /// <summary>
        /// Returns a blue variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Blue(int variation = 5)
        {
            CheckInstance();

            return BlueVariations[variation];
        }

        /// <summary>
        /// Returns a light blue variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 LightBlue(int variation = 5)
        {
            CheckInstance();

            return LightBlueVariations[variation];
        }

        /// <summary>
        /// Returns a cyan variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Cyan(int variation = 5)
        {
            CheckInstance();

            return CyanVariations[variation];
        }

        /// <summary>
        /// Returns a teal variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Teal(int variation = 5)
        {
            CheckInstance();

            return TealVariations[variation];
        }

        /// <summary>
        /// Returns a green variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Green(int variation = 5)
        {
            CheckInstance();

            return GreenVariations[variation];
        }

        /// <summary>
        /// Returns a light green variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 LightGreen(int variation = 5)
        {
            CheckInstance();

            return LightGreenVariations[variation];
        }

        /// <summary>
        /// Returns a lime variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Lime(int variation = 5)
        {
            CheckInstance();

            return LimeVariations[variation];
        }

        /// <summary>
        /// Returns a yellow variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Yellow(int variation = 5)
        {
            CheckInstance();

            return YellowVariations[variation];
        }

        /// <summary>
        /// Returns an amber variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Amber(int variation = 5)
        {
            CheckInstance();

            return AmberVariations[variation];
        }

        /// <summary>
        /// Returns an orange variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 Orange(int variation = 5)
        {
            CheckInstance();

            return OrangeVariations[variation];
        }

        /// <summary>
        /// Returns a deep orange variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 13)</param>
        public static Color32 DeepOrange(int variation = 5)
        {
            CheckInstance();

            return DeepOrangeVariations[variation];
        }

        /// <summary>
        /// Returns a brown variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 9)</param>
        public static Color32 Brown(int variation = 5)
        {
            CheckInstance();

            return BrownVariations[variation];
        }

        /// <summary>
        /// Returns a grey variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 9)</param>
        public static Color32 Grey(int variation = 5)
        {
            CheckInstance();

            return GreyVariations[variation];
        }

        /// <summary>
        /// Returns a blue grey variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 9)</param>
        public static Color32 BlueGrey(int variation = 5)
        {
            CheckInstance();

            return BlueGreyVariations[variation];
        }

        /// <summary>
        /// Returns a grayscale variation (default 5)
        /// </summary>
        /// <param name="variation">Variation index (between 0 and 9)</param>
        public static Color32 Grayscale(int variation = 5)
        {
            CheckInstance();

            return GrayscaleVariations[variation];
        }
        #endregion

        #region Random Functions
        /// <summary>
        /// Returns a random color with variation index
        /// </summary>
        /// <param name="variation">Color variation index</param>
        public static Color32 GetRandomColorVariation(int variation)
        {
            CheckInstance();

            int randomColorIndex = Random.Range(0, Colors.Count);
            List<Color32> colorVariations = Colors.ElementAt(randomColorIndex).Value;

            return colorVariations[variation];
        }

        /// <summary>
        /// Returns a random color with random variation
        /// </summary>
        public static Color GetRandomColor()
        {
            CheckInstance();

            int randomColorIndex = Random.Range(0, Colors.Count);
            List<Color32> colorVariations = Colors.ElementAt(randomColorIndex).Value;

            int randomColorVariationIndex = Random.Range(0, colorVariations.Count);
            return colorVariations[randomColorVariationIndex];
        }
        #endregion

        #region Helpers
        private static void CheckInstance()
        {
            if (_instance == null)
            {
                _instance = new MaterialColor();
                Debug.Log("Initialized Colorizer");
            }
        }
        #endregion
    }
}
