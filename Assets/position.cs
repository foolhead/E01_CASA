using UnityEngine;
using System.Collections;

public class position : MonoBehaviour {
	public GameObject parent;
	// Use this for initialization
	void Start () {
		this.transform.position = parent.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = parent.transform.position;
	}
}

