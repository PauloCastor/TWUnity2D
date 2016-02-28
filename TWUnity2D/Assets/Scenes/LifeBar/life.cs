using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class life : MonoBehaviour {

	public Scrollbar vida;
	public Text t;
	public float res = 100.0F;
	public int num = 100;

	public void Damage(float valor)
	{

		res -= valor;
		vida.size = res  / 100.0F ;
		num = (int)res ;
		t.text = num.ToString ();
	}


}
