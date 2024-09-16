using UnityEngine;
using UnityEngine.UI;

namespace VisualDesign.FlexibleUI
{
    [CreateAssetMenu(menuName = "Flexible UI/Create Data: Button Skin")]
    public class ButtonData : ScriptableObject
    {
        public Sprite buttonSprite;
        public SpriteState buttonSpriteState;

        public Color defaultColor;
        public Sprite defaultIcon;

        public Color confirmColor;
        public Sprite confirmIcon;

        public Color declineColor;
        public Sprite declineIcon;

        public Color warningColor;
        public Sprite warningIcon;
    }
}
