using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisualDesign.FlexibleUI
{
  [ExecuteInEditMode()]
  public class CreateAsset : MonoBehaviour
  {
    public ButtonData assetData;

    protected virtual void OnFlexibleUI() { }

    public virtual void Awake()
    {
      OnFlexibleUI();
    }

    public virtual void Update()
    {
      if (Application.isEditor)
      {
        OnFlexibleUI();
      }
    }
  }
}
