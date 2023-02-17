using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoketme : MonoBehaviour
{
    public GameObject patlama;
    gameplay gameplayscript;


    private void Start()
    {
        gameplayscript = GameObject.Find("_Scripts").GetComponent<gameplay>();

    }

    public void OnMouseDown()
    {
        GameObject go= Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy (go, 0.367f);
        gameplayscript.skorsonucu();

    }
}
