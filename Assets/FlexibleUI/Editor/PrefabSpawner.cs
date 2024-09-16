using UnityEditor;
using UnityEngine;

namespace VisualDesign.FlexibleUI {
  public class PrefabSpawner : EditorWindow {

    string objectBaseName = "";
    int objectID = 1;

    GameObject objectToSpawn;
    float objectScale = 1;
    float spawnRadius = 5f;

    Transform objectContainer;
    bool appendID;

    [MenuItem("GameObject/Flexible UI/Spawn Prefab(s)")]
    public static void ShowWindow() {
      GetWindow(typeof(PrefabSpawner)); // GetWindow is a method inherited from the EditorWindow class
    }

    private void OnGUI() {
      GUILayout.Label("Spawn New Object", EditorStyles.boldLabel);
      EditorGUILayout.Space();

      objectToSpawn = EditorGUILayout.ObjectField("Prefab to Spawn", objectToSpawn, typeof(GameObject), false) as GameObject;
      objectContainer = EditorGUILayout.ObjectField("Object Container", objectContainer, typeof(Transform), true) as Transform;
      EditorGUILayout.HelpBox("*must be a scene object", MessageType.None, false);

      EditorGUILayout.Space();
      objectBaseName = EditorGUILayout.TextField("Base Name", objectBaseName);
      appendID = EditorGUILayout.BeginToggleGroup("Append Numerical ID", appendID);
      EditorGUI.indentLevel++;
      objectID = EditorGUILayout.IntField("Object ID", objectID);
      EditorGUI.indentLevel--;

      EditorGUILayout.Space();
      EditorGUILayout.EndToggleGroup(); objectScale = EditorGUILayout.Slider("Object Scale", objectScale, 0.5f, 3f);
      spawnRadius = EditorGUILayout.FloatField("Spawn Radius", spawnRadius);

      EditorGUILayout.Space();
      EditorGUI.BeginDisabledGroup(objectToSpawn == null || objectBaseName == string.Empty || (objectContainer != null && EditorUtility.IsPersistent(objectContainer)));
      if (GUILayout.Button("Spawn Object")) {
        SpawnObject();
      }
      EditorGUI.EndDisabledGroup();

      EditorGUILayout.Space();
      if (objectToSpawn == null) {
        EditorGUILayout.HelpBox("Place a GameObject in the 'Prefab to Spawn' field.", MessageType.Warning);
        // Debug.LogError("Error: Please assign an object to be spawned.");
      }
      if (objectBaseName == string.Empty) {
        EditorGUILayout.HelpBox("Assign a base name to the object to be spawned.", MessageType.Warning);
        // Debug.LogError("Error: Please enter a base name for the object.");
      }
      if (objectContainer != null && EditorUtility.IsPersistent(objectContainer)) {
        EditorGUILayout.HelpBox("Object Container must be a scene object.", MessageType.Warning);
      }
    }

    private void SpawnObject() {
      Vector2 spawnCircle = Random.insideUnitCircle * spawnRadius;
      Vector3 spawnPos = new Vector3(spawnCircle.x, 0f, spawnCircle.y);

      GameObject newObject = Instantiate(objectToSpawn, spawnPos, Quaternion.identity);
      newObject.name = objectBaseName + objectID;
      newObject.transform.localScale = Vector3.one * objectScale;

      objectID++;
    }
  }
}

// https://www.youtube.com/watch?v=34736DHWzaI
