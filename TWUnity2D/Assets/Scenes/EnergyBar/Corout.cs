using UnityEngine;
using System.Collections;

public class Corout : MonoBehaviour {

	public float forca = 2.0F;
	public Rigidbody2D bola;
	public bool interruptor = true;

	void Start () {

		StartCoroutine (move());
	}
	


	public IEnumerator move()
	{
		while(interruptor == true)
		{
			yield return new WaitForSeconds(2);
			bola.AddForce (new Vector2 (0.0F, forca),ForceMode2D.Impulse);
		}
	}
}
