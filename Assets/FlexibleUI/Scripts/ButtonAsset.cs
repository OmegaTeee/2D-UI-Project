using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VisualDesign.FlexibleUI
{

  [RequireComponent(typeof(Button))]
  [RequireComponent(typeof(Image))]

  public class ButtonAsset : CreateAsset
  {
    public enum ButtonType
    {
      Default,
      Confirm,
      Decline,
      Warning,
    }

    Image image;
    Image icon;
    Button button;

    public ButtonType buttonType;

    protected override void OnFlexibleUI()
    {
      base.OnFlexibleUI();

      image = GetComponent<Image>();
      icon = transform.Find("Icon").GetComponent<Image>();
      button = GetComponent<Button>();

      button.transition = Selectable.Transition.SpriteSwap;
      button.targetGraphic = image;

      image.sprite = assetData.buttonSprite;
      image.type = Image.Type.Sliced;
      button.spriteState = assetData.buttonSpriteState;

      switch (buttonType)
      {
        case ButtonType.Confirm:
          image.color = assetData.confirmColor;
          icon.sprite = assetData.confirmIcon;
          break;

        case ButtonType.Decline:
          image.color = assetData.declineColor;
          icon.sprite = assetData.declineIcon;
          break;

        case ButtonType.Default:
          image.color = assetData.defaultColor;
          icon.sprite = assetData.defaultIcon;
          break;

        case ButtonType.Warning:
          image.color = assetData.warningColor;
          icon.sprite = assetData.warningIcon;
          break;
      }
    }
  }
}
