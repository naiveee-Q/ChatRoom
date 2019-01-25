using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

	public List<string> text = new List<string> ();
	public List<int> wait = new List<int> ();

	public int textNow = 13;
	private int showNow = 0;
	private int waitTime = 0;
	public GameObject parent;
	public GameObject text_panel;

	// Use this for initialization
	void Start () {
		text.Add (">> Evil God: Hello?");
		text.Add (">> Evil God: Anyone here?");
		text.Add (">> Link: Hi, what's up?");
		text.Add ("<< ??");
		text.Add (">> Evil God: It is wried.");
		text.Add (">> Evil God: Is it 2008 now?");
		text.Add ("<< Interesting.");
		text.Add (">> Link: OK, continue.");
		text.Add (">> Evil God: It is true!!!");
		text.Add (">> Evil God: I AM FROM 2008");
		text.Add (">> Link: Yeah yeah");
		text.Add ("<< I am from 3000 lol");
		text.Add (">> Evil God: FUCK");

		wait.Add (50);
		wait.Add (50);
		wait.Add (100);
		wait.Add (20);
		wait.Add (60);
		wait.Add (50);
		wait.Add (90);
		wait.Add (40);
		wait.Add (70);
		wait.Add (70);
		wait.Add (80);
		wait.Add (60);
		wait.Add (50);
		wait.Add (60);
		wait.Add (50);
	}
	
	// Update is called once per frame
	void Update () {
		if (waitTime < wait [showNow]) {
			waitTime++;
			return;
		}
		if (textNow > showNow) {
			GameObject panel = Instantiate (text_panel);
			panel.transform.Find ("Text").GetComponent<Text> ().text = text [showNow];
			panel.transform.SetParent(parent.transform);
			showNow++;
			waitTime = 0;
		}

	}
}
