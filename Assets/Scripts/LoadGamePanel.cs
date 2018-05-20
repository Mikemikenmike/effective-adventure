using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadGamePanel : MonoBehaviour {

	public GameObject PanelPrefab;

	// Use this for initialization
	void Start () {
		var info = new DirectoryInfo(Application.persistentDataPath + "/worlds");
		var fileInfo = info.GetFiles();
		for (var i=0; i < fileInfo.Length; i++) {
			
			GameObject panel = Instantiate(PanelPrefab);
			
			panel.transform.SetParent(transform, false);
			panel.transform.localPosition += new Vector3(0f, panel.transform.localPosition.y - panel.GetComponent<RectTransform>().rect.height * i);

			Text title = panel.GetComponentInChildren<Transform>().Find("GameTitle").GetComponent<Text>();
			title.text = fileInfo[i].Name;

			panel.GetComponent<LoadGamePrefab>().Location = fileInfo[i].FullName;
	
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
