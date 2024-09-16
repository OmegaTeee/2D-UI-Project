using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace VisualDesign
{
  public class PrefabSwapper : MonoBehaviour
  {
    [SerializeField]
    private GameObject selectedVariant; // Field to assign the variant from the scene

    [SerializeField]
    private GameObject currentPrefabInstance; // Scene instance of the _BaseRoot

    private void Awake()
    {
      // Automatically find the current instance if it hasn't been set manually
      if (currentPrefabInstance == null)
      {
        currentPrefabInstance = gameObject; // Assign the script's gameObject as the current prefab instance
        Debug.Log("Automatically assigned currentPrefabInstance to the game object: " + gameObject.name);
      }
    }

    public void SwapPrefab()
    {
      if (selectedVariant == null)
      {
        Debug.LogError("No variant selected! Please assign a scene object.");
        return;
      }

      if (currentPrefabInstance == null)
      {
        Debug.LogError("Current prefab instance is null! Ensure it's assigned or detected automatically.");
        return;
      }

      // Save original object's name, parent, and transform properties
      string originalName = currentPrefabInstance.name;
      Transform parentTransform = currentPrefabInstance.transform.parent;
      Vector3 originalPosition = currentPrefabInstance.transform.localPosition;
      Quaternion originalRotation = currentPrefabInstance.transform.localRotation;
      Vector3 originalScale = currentPrefabInstance.transform.localScale;

      // Destroy the current object in the scene
      DestroyImmediate(currentPrefabInstance);

      // Instantiate the selected variant in the scene
      GameObject newObject = Instantiate(selectedVariant, originalPosition, originalRotation, parentTransform);
      newObject.transform.localScale = originalScale;

      // Preserve the original name
      newObject.name = originalName;

      // Update the reference to the current prefab instance
      currentPrefabInstance = newObject;
    }
  }
}
