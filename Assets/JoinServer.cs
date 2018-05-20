using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;

public class JoinServer : MonoBehaviour {

	public Text IP;
	private string _ip = "127.0.0.1";
	
	public Text Port;
	private int _port = 4444;
	
	public Game game;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Join() {
		if (IP.text != "") {
			_ip = IP.text;
		}

		if (Port.text != "") {
			_port = int.Parse(Port.text);
		}
		game.JoinGame(_ip, _port);
	}
}
