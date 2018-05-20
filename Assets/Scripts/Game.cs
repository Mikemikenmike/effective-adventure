using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class Game : MonoBehaviour {

	public static string GameName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void NextScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public void CreateGame(Text gameName) {
		GameName = gameName.text;
		Debug.Log(GameName);
//		NextScene("11_Game");
		NetworkServer.Listen(4444);
		NetworkClient myClient = new NetworkClient();
		myClient.RegisterHandler(MsgType.Connect, OnConnected);
		myClient.RegisterHandler(MsgType.Error, OnError);
		myClient.Connect("127.0.0.1", 4444);
	}
	
	public void OnConnected(NetworkMessage netMsg) {
		Debug.Log("Connected to server");
		NextScene("11_Game");
	}

	public void OnError(NetworkMessage netMsg) {
		Debug.Log("Error");
	}

	public void LoadGame(string location) {
		GameName = location;
	}

	public void JoinGame(string ip, int port) {
		NetworkClient myClient = new NetworkClient();
		myClient.RegisterHandler(MsgType.Connect, OnConnected);
		myClient.RegisterHandler(MsgType.Error, OnError);
		myClient.Connect(ip, port);
	}

	public void SaveGame() {
		Save save = CreateSaveGameObject();

		if (!Directory.Exists(Application.persistentDataPath + "/worlds")) {
			Directory.CreateDirectory(Application.persistentDataPath + "/worlds");
		}
		
		Debug.Log(GameName);
		string destination = Application.persistentDataPath + "/worlds/" + GameName + ".dat";
		Debug.Log(destination);
		
		FileStream file;
		if (File.Exists(destination)) file = File.OpenWrite(destination);
		else file = File.Create(destination);
		
		BinaryFormatter bf = new BinaryFormatter();
		bf.Serialize(file, JsonUtility.ToJson(save));
		file.Close();
	}

	private Save CreateSaveGameObject() {
		Save save = new Save();
		
		GameObject world = GameObject.Find("World");
		foreach (Transform block in world.transform) {
			SerialCube cube = new SerialCube();
			cube.color = block.GetComponent<Renderer>().material.color;
			cube.pos = block.localPosition;
			save.blocks.Add(cube);
		}

		return save;
	}

}
