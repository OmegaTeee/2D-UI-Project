using UnityEngine;

namespace VisualDesign.GUI {
  public abstract class ComponentBase : MonoBehaviour {
    private void Awake() {
      Init();
    }
    public abstract void Setup();
    public abstract void Configure();

    // [Button("Reconfigure Now")]
    private void Init() {
      Setup();
      Configure();
    }

    private void OnValidate() {
      Init();
    }
  }
}
