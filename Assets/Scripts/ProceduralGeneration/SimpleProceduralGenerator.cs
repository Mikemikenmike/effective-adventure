using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using Random = UnityEngine.Random;

public class SimpleProceduralGenerator : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
		Debug.Log(Game.GameName);

		if (File.Exists(Game.GameName)) {
			Inflate();
		}
		else {
			GameObject world = new GameObject();
			world.name = "World";
			float length = Random.Range(40, 100);
			float width = Random.Range(40, 100);


			for (var i = 0; i < width; i++) {
				for (var u = 0; u < length; u++) {
					float roll = Random.Range(0, 100);
					GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
					floor.transform.parent = world.transform;
					if (roll > 30 || (i == 0 && u == 0)) {
						floor.GetComponent<Renderer>().material.color = Color.blue;
						floor.transform.localPosition = new Vector3(i, 0, u);
					}
					else {
						floor.GetComponent<Renderer>().material.color = Color.red;
						floor.transform.localPosition = new Vector3(i, -1, u);
					}
				}
			}

			Game game = GameObject.Find("SceneManager").GetComponent<Game>();
			game.SaveGame();	
		}
	}

	private void Inflate() {
		Debug.Log(Game.GameName);
		string data = File.ReadAllText(Game.GameName);
		Debug.Log(data);
		
		BinaryFormatter bf = new BinaryFormatter();

		using (FileStream stream = new FileStream(Game.GameName, FileMode.Open, FileAccess.Read)) {
			
		}
	}
}
