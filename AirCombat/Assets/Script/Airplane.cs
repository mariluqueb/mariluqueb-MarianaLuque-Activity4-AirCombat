using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right);
        }

        //Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left);
        }

        //UP
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        }

        //Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        }

        //Space
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Creamos un gameObject a partit de un prefab (planos de una edicifio)
            GameObject newMisille = GameObject.Instantiate(Resources.Load("Bullets/Misille") as GameObject);

            // Buscamos el gameObject del pivote de disparo (shootPivot)
            GameObject shootPivot = GameObject.Find("Airplane/ShootPivot");

            //Hago el misil a la posicion del pivote de disparo
            newMisille.transform.SetParent(shootPivot.transform);

            //movemos el misil hijo de shoot pivot
            newMisille.transform.localPosition = Vector3.zero;

            //Saco el Misil del pivote ara que no se mueva el avion
            newMisille.transform.SetParent(null);

        }
    }
}