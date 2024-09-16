using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace VisualDesign.FlexibleUI {
  public class CreateInstance : Editor {

    [MenuItem("GameObject/Flexible UI/Button", priority = 0)]
    public static void AddButton() {
      Create("Button");
    }

    static GameObject clickedObject;

    private static GameObject Create(string objectName) {
      GameObject instance = Instantiate(Resources.Load<GameObject>(objectName));
      instance.name = objectName;
      clickedObject = UnityEditor.Selection.activeObject as GameObject;
      if (clickedObject != null) {
        instance.transform.SetParent(clickedObject.transform, false);
      }
      return instance;
    }
  }
}

// https://www.youtube.com/playlist?list=PLX2vGYjWbI0TDfkKmzcXSK7zrFWEPZbQu