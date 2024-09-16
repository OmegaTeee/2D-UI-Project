using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace VisualDesign
{
  using UnityEditor;
  using UnityEngine;

  [CustomEditor(typeof(PrefabSwapper))]
  public class PrefabSwapperEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      // Draw the default inspector
      DrawDefaultInspector();

      // Get the reference to the PrefabSwapper script
      PrefabSwapper prefabSwapper = (PrefabSwapper)target;

      // Add a button to trigger the swap
      if (GUILayout.Button("Swap Prefab"))
      {
        prefabSwapper.SwapPrefab();
      }
    }
  }
}
