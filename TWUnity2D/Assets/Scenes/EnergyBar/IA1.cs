using UnityEngine;
using System.Collections;

public class IA1 : MonoBehaviour {

	public float distancia;
	public Transform outro;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			float angle = 0;
			
		Vector3 relative = transform.InverseTransformPoint(outro.position);
			angle = Mathf.Atan2(relative.x, relative.y)*Mathf.Rad2Deg;
			transform.Rotate(0,0, -angle);

		transform.Translate (new Vector2 (0,0.1f),Space.Self);

		distancia = Vector2.Distance (transform.position, outro.position);
	}
}
