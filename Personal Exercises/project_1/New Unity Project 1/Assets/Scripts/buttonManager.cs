using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonManager : MonoBehaviour {

	string input = "";

	//code which is triggered whent he button is pressed
	public void helloButtonPressed()
	{
		//1. read the value in the text box
		//2. create a string to write in the output box
		//3. writeupdate the string to the output box. 

		string input = GameObject.Find("InputField").GetComponent<InputField>().text;

		input = "Hello, " + input;

		GameObject.Find ("OutputText").GetComponent<Text> ().text = input;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
