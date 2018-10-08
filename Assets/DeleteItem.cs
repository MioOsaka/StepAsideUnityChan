using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : MonoBehaviour {
	private GameObject mainCamera;

	void Start () {
		this.mainCamera = GameObject.Find ("Main Camera");
	}

	void Update () {
		if(mainCamera.transform.position.z > this.transform.position.z){
			Destroy (this.gameObject);
		}
	}



//	void OnBecameInvisible()
//	{
//		Destroy(this.gameObject);
//	}
}