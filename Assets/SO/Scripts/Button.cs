using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace VisualDesign.GUI {
  public class Button : ComponentBase {

    public ThemeSO theme;
    public Style style;
    public UnityEvent onClick;
    public ColorBlock colors;

    private Button button;
    private Image buttonImage;
    private TextMeshProUGUI buttonText;
    private Outline buttonOutline;

    public override void Setup() {
      button = GetComponentInChildren<Button>();
      buttonImage = GetComponentInChildren<Image>();
      buttonText = GetComponentInChildren<TextMeshProUGUI>();
      buttonOutline = GetComponentInChildren<Outline>();
      // buttonContainer = GetComponent<Transform>() ;
    }

    public override void Configure() {
      ColorBlock cb = button.colors;
      cb.normalColor = theme.GetBackgroundColor(style);
      cb.highlightedColor = theme.GetBackgroundColor(style);
      cb.pressedColor = theme.GetBackgroundColor(style);
      cb.selectedColor = theme.GetBackgroundColor(style);
      cb.disabledColor = theme.GetBackgroundColor(style);
      button.colors = cb;

      buttonText.color = theme.GetTextColor(style);
      buttonImage.color = theme.GetBackgroundColor(style);
      buttonOutline.effectColor = theme.GetTextColor(style);
    }

    public void OnClick() {
      onClick.Invoke();
    }
  }
}
