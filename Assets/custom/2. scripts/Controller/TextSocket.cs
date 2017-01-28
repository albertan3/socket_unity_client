using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;
using SocketIO;
using UnityEngine.UI;

public class TextSocket : MonoBehaviour {
	
	public GameObject guiText;
	private SocketIOComponent socket;
	private Text _guiText;


	// Use this for initialization
	void Start () {
	
		GameObject go = GameObject.Find("SocketIO");
		socket = go.GetComponent<SocketIOComponent>();
		socket.On ("logintext",changeSocketText);

		_guiText = guiText.GetComponent<Text> ();

	}//start
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {

			Dictionary<string,string> json = new Dictionary<string, string>();
			json.Add("logintext","I am a cybor human");

			socket.Emit("logintext",new JSONObject(json));

		}//click
	}//update


	public void changeSocketText(SocketIOEvent e){
		JSONObject jo = e.data as JSONObject;

		_guiText.text = jo["logintext"].str;

	}//changeSocketText

}
