using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {

	public void OnDrag(){ transform.position = Input.mousePosition; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
