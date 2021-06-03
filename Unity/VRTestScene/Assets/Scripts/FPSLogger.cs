using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSLogger : MonoBehaviour
{
	[SerializeField]
	private float loggingInterval = 10.0f;

	private int currentFPS;
	private TextMeshPro text;
	private List<int> loggedFPS = new List<int>();

	private void Start()
	{
		text = GetComponent<TextMeshPro>();
		InvokeRepeating("LogAverageFPS", loggingInterval, loggingInterval);
	}

	private void Update()
	{
		currentFPS = (int)(1f / Time.unscaledDeltaTime);
		text.text = currentFPS.ToString() + " FPS";
		loggedFPS.Add(currentFPS);
		//Debug.Log("Current FPS is at " + text.text);
	}

	//Log average of the past x seconds in which x is set in the inspector
	private void LogAverageFPS()
	{
		Debug.Log($"Average FPS for the past {loggingInterval} seconds at : {Time.time.ToString()} seconds in is at {loggedFPS.Average().ToString()} FPS");
		loggedFPS.Clear();
	}
}

