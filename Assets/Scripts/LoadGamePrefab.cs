using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGamePrefab : MonoBehaviour {

	public string Location;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void LoadGame() {
		GameObject.Find("SceneManager").GetComponent<Game>().LoadGame(Location);
	}

}
