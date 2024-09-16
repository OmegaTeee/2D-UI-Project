using UnityEngine;

namespace VisualDesign.FlexibleUI
{
  public abstract class WrapperInitializer : MonoBehaviour
  {
    private void Awake()
    {
      Init();
    }
    public abstract void Setup();
    public abstract void Configure();

    // [Button("Reconfigure Now")]
    private void Init()
    {
      Setup();
      Configure();
    }

    private void OnValidate()
    {
      Init();
    }
  }
}
