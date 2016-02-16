using UnityEngine;
//1.
using UnityEngine.UI;
using System.Collections;

public class buttonManager : MonoBehaviour {

	string input = "";

	//code which is triggered when the button is pressed
	public void helloButtonPressed()
	{
		//1. read the value in the text box
		//2. create a string to write in the output box
		//3. write/update the string to the output box 

		//1.
		string input = GameObject.Find("InputField").GetComponent<InputField>().text;

		//2.
		input = "Hello, " + input;

		//3.
		GameObject.Find ("OutputText").GetComponent<Text> ().text = input;
	}

	//code triggered when the image button is pressed

	public void Button2Pressed()
	{
		//1. Check if the image is visible
		//2. if the image is visible, hide the image. 
		//3. if the image is hidden, show the image. 

		bool imageVisible = true;

		imageVisible = GameObject.Find ("Image1").GetComponent<RawImage> ().enabled;

		if (imageVisible == true) {
			//hide the image
			GameObject.Find ("Image1").GetComponent<RawImage> ().enabled = false;

		} else {
			//show the image
			GameObject.Find ("Image1").GetComponent<RawImage>().enabled = true;
		}

	}
	//code for when the next button is pressed
	public void nextButtonPressed()
	{
		Application.LoadLevel ("scene2");
	}
	//code which is triggered when the previous button is pressed
	public void previousButtonPressed()
	{
		Application.LoadLevel ("scene1");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
