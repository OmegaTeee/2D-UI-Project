using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace VisualDesign.GUI {
  public class Text : ComponentBase {

    public TextSO textData;
    public Style style;

    private TextMeshProUGUI textMeshProUGUI;

    public override void Setup() {
      textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
    }

    public override void Configure() {
      textMeshProUGUI.color = textData.theme.GetTextColor(style);
      textMeshProUGUI.font = textData.font;
      textMeshProUGUI.fontSize = textData.size;
    }
  }
}
