using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour {
	private int random;
	Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			GenerateColor ();
		}
	}

	void GenerateColor() {
		random = Random.Range (0,6);
		Color newColor = new Color ();
		switch (random) {
		case 0:
			newColor = Color.black;
			break;
		case 1:
			newColor = Color.red;
			break;
		case 2:
			newColor = Color.blue;
			break;
		case 3:
			newColor = Color.yellow;
			break;
		case 4:
			newColor = Color.green;
			break;
		case 5:
			newColor = Color.grey;
			break;
		case 6:
			newColor = Color.magenta;
			break;
		default:
			newColor = Color.white;
			break;
		}
		rend.material.color = newColor;
	}
}
