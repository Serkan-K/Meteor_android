using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meteorkod : MonoBehaviour
{

    public GameObject meteor;
    float meteorolusturmasuresi = 1f;
    float zamansayici = 0f;
    gameplay gameplayscript;

    void Start()
    {
        gameplayscript = this.gameObject.GetComponent<gameplay>();

    }


    void Update()
    {
        zamansayici -= Time.deltaTime;
        int zorluk = (int)(gameplayscript.zamansayaci / 5) -12;
        zorluk *= -1;


        if (zamansayici < 0 && gameplayscript.zamansayaci > 0)
        {
            GameObject go = Instantiate(meteor, new Vector3(Random.Range(-2.1f, 2.1f), 6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, Random.Range(-10*zorluk,-50*zorluk), 0));
            
            
            zamansayici = meteorolusturmasuresi;

        }
    }



public void digersahne()
    {
        SceneManager.LoadScene("oyun_meteor");
    }



}

