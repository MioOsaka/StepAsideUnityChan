using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : MonoBehaviour {

	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
}