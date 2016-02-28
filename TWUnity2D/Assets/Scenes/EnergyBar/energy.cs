using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class energy : MonoBehaviour {

	public Scrollbar energia;
	public float res = 50.0F;
	public enum Estados {enfraquecendo,fortalecendo};
	public int posicao;

	void Start()
	{
		posicao = (int)Estados.fortalecendo;
	}
	
	void Update(){

		if (posicao == 0) {
			res -= 0.1F;
		} else if (posicao == 1) {
			res += 0.1F;
		}


		energia.size = res  / 100.0F ;

	}
	
	
}
