using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSLogger : MonoBehaviour
{
	private int averageFPS;
	private TextMeshPro text;

	private void Start()
	{
		text = GetComponent<TextMeshPro>();
	}

	public void Update()
	{
		averageFPS = (int)(1f / Time.unscaledDeltaTime);
		text.text = averageFPS.ToString() + " FPS";
		Debug.Log("Current FPS is at " + text.text);
	}
}

