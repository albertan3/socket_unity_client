using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraBack : MonoBehaviour {


	public WebCamTexture mCamera = null;
	public GameObject cardCamHere;
	public Texture finishedTexture;
	// Use this for initialization
	void Start () {

		mCamera = new WebCamTexture ();

		//Camera.main.GetComponent = mCamera;
		cardCamHere.GetComponent<Renderer> ().material.mainTexture = mCamera;

		mCamera.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
