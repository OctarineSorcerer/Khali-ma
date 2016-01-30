using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	
    public float lettersPerSecond;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetText(string text)
    {
		StopCoroutine ("ScrollThroughText");
		StartCoroutine ("ScrollThroughText", text);
    }

    public IEnumerator ScrollThroughText(string text) //Just won't be visible with buttons really
    {
        Text displayText = GetComponentInChildren<Text>();
        float waitTime = 1 / lettersPerSecond;

        if (lettersPerSecond == 0) displayText.text = text; //User wants to display immediately
        else
        {
            displayText.text = "";
            foreach (char c in text)
            {
                displayText.text += c;
                yield return new WaitForSeconds(waitTime);
            }
        }
    }
}
