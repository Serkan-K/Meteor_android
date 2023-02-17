using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, skorText;
    public GameObject patlama;
    public float zamansayaci = 60;
    public UnityEngine.UI.Button btn;
    int skor = 0;


    void Start()
    {
        skorText.text = "" + skor;
    }

   
    void Update() {
        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
            zamanText.text = "" + (int)zamansayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("meteor_tag");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);

                Destroy(go[i]);
                btn.gameObject.SetActive(true);

            }
        }
    }

        public void skorsonucu()
        {

            skor += 100;
            skorText.text = "" + skor;

        }


    }
