using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace VisualDesign.GUI {
  [CreateAssetMenu(menuName = "CustomUI/Text: SO Data")]
  public class TextSO : ScriptableObject {
    public ThemeSO theme;

    public TMP_FontAsset font;
    public float size;
  }
}
