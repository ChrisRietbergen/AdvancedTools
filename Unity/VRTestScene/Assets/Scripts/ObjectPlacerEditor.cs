using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(ObjectPlacer))]
public class ObjectPlacerEditor : Editor
{

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		ObjectPlacer objectPlacer = (ObjectPlacer)target;
		if (GUILayout.Button("Place 10x10x10"))
		{
			objectPlacer.Place10x10x10();
		}
		if (GUILayout.Button("Place 20x20x20"))
		{
			objectPlacer.Place20x20x20();
		}
		if (GUILayout.Button("Place 50x50x50"))
		{
			objectPlacer.Place50x50x50();
		}
		if (GUILayout.Button("Clear objects"))
		{
			objectPlacer.ClearAll();
		}
	}
}
