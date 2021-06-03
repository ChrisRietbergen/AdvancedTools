using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private int sizeMultiplier;


	public void Place10x10x10()
	{
		ClearAll();
		PlaceObjects(10, 10, 10);
	}
	public void Place20x20x20()
	{
		ClearAll();
		PlaceObjects(20, 20, 20);
	}
	public void Place50x50x50()
	{
		ClearAll();
		PlaceObjects(50, 50, 50);
	}

	public void ClearAll()
	{
		foreach(Transform transform in GetComponentsInChildren<Transform>())
		{
			if(transform == this.transform)
			{
				//Skip yourself because Unity still insists on adding the parent's transform to the list retrieved from GetComponentsInChildren
				//Checked the Debuglog, it gets called every time
				//Debug.Log("Don't destroy yourself, idiot");
			}
			else
			{
				DestroyImmediate(transform.gameObject);
			}
		}
	}

	//Places all objects according to specifications
	private void PlaceObjects(int x, int y, int z)
	{
		for (int i =  -(x/2); i <= (x/2); i++)//Offset them along the X axis to make them all in screen
		{
			for (int j = 1; j <= y; j++)
			{
				for (int h = 1; h <= z; h++)
				{
					Instantiate(prefab, new Vector3(i * sizeMultiplier, j * sizeMultiplier, h * sizeMultiplier), Quaternion.identity, transform);
				}
			}
		}
	}
}
