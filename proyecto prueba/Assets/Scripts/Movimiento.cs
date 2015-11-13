using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	public float fuerza = 200f;//indica la fuerza que va a tener el objeto
	public float velocidad = 10f;//indica la velocidad que va a tener el objeto
	Rigidbody2D rg;//esto es para usar el rigthbody del objeto
	Vector3 mira_izquierda = new Vector3 (1,1,1);//vector 2 solo tiene x e y, vector 3 tiene x,z e y
	Vector3 mira_derecha = new Vector3 (-1,1,1);
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D>(); //Cargamos el Rigitbody dentro
	}
	
	// Update is called once per frame
	void Update () {
		//si pulsamos el espacio saltamos
		if(Input.GetKeyDown(KeyCode.Space)){ //hacer que con espacio indique que salte cada vez que se pulse esa tecla, pero sin mantenerla--->   (Getkeydown)
			salto();
		} 
		if (Input.GetKey(KeyCode.A)){ //hacer que con espacio indique que A, con solo pulsar la tecla el objeto se movera consecutivamente---->    (Getkey)
			mueve_izquierda();
		}

		if (Input.GetKey(KeyCode.D)){ //hacer que con espacio indique que D, con solo pulsar la tecla el objeto se movera consecutivamente---->    (Getkey)
			mueve_derecha();

		}

		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity;
		Debug.DrawLine(transform.position,
		               new Vector3(transform.position.x + velocidad.x,
		            transform.position.y + velocidad.y,
		            transform.position.z));
	
	}


	/*Funcion salto
	 *Aplica una fuerza al objeto con fuerza: fuerza 
	 */
	void salto(){
		Debug.Log("Salta!!"); //comprobando que salta
		rg.AddForce(new Vector2(0,fuerza)); //Coge el componente rigtbody 2d añade fuerza
	}

	void mueve_izquierda(){
		transform.localScale = mira_izquierda;
		//rg.AddForce(new Vector2(-velocidad,0));//se utiliza menos porque en coordenadas la izquierda tiene "menos"
		rg.velocity = new Vector2(-velocidad,0);
	}
	void mueve_derecha(){
		transform.localScale = mira_derecha;
		//rg.AddForce(new Vector2(velocidad,0));//se utiliza mas porque en coordenadas la derecha tiene "mas"
		rg.velocity = new Vector2(velocidad,0);

	}



		/*Funcion mueve_izquierda
		 * Esta funcion hace que el objeto mire hacia la derecha
		 * y se mueva con una velocidad: velocidad_pollo
		 */

}
