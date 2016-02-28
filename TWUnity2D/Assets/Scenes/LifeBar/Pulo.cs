using UnityEngine;
using System.Collections;

public class Pulo : MonoBehaviour {

	public float forca = 2.0F;
	public Rigidbody2D mario;
	public int Estado = 1;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Estado != 0)
		{


			if (Input.GetKeyDown ("space")) {

				Estado -= 1;
				mario.AddForce(new Vector2(0.0F,forca),ForceMode2D.Impulse);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col )

	{
		if (col.gameObject.CompareTag ("chao")) {

			Estado = 1;
		}
	}

	/*void OnCollisionExit2D(Collision2D col )
		
	{
		if (col.gameObject.CompareTag ("chao")) {
			
			//Estado = 0;
		}
	}*/
}
