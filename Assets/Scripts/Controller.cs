using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
	[SerializeField] private float _speed = 50;

	// Update is called once per frame
	void Update() { transform.Rotate(new Vector3(_speed, 0, 0) * Time.deltaTime); }
}
