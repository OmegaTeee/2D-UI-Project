using UnityEngine;

namespace VisualDesign.FlexibleUI
{
  [CreateAssetMenu(menuName = "Flexible UI/Create Data: Component Wrapper")]
  public class WrapperData : ScriptableObject
  {
    public string elementName; // Name of the UI element (optional)
    public string textContent; // Text for UI components like Text, Button, etc.
    public Color backgroundColor; // Background color for UI element
    public Color textColor; // Text color for UI element
    public Vector2 size; // Width and height of the UI element
    public int fontSize; // Font size for text elements
  }
}

