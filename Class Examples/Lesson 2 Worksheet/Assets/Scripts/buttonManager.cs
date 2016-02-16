using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonManager : MonoBehaviour {

	public void nextButtonPressed()
	{
		int i = Application.loadedLevel;
		Application.LoadLevel (i + 1);	
	}
	public void prevButtonPressed()
	{
		int i = Application.loadedLevel;
		Application.LoadLevel (i - 1);
	}
	public void firstButtonPressed()
	{
		Application.LoadLevel ("scene1");
	}
	public void lastButtonPressed()
	{
		Application.LoadLevel ("scene3");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
