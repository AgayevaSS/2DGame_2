using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggs : MonoBehaviour
{
    //[SerializeField] public int aggsCount;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Aggs"))
    //    {
    //        Debug.Log("DFHGH");
    //        FireCollect();
    //        Destroy(other.gameObject);


    //    }

    //}
    //private void FireCollect()
    //{

    //    aggsCount++;
    //    Debug.Log(aggsCount);
    //}

    [SerializeField] GameObject _death;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject finish;


    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Aggs"))
        {
            Destroy(collision. gameObject);

            _death.SetActive(true);

            panel.SetActive(true);


        }
        //if (collision.gameObject.CompareTag("Finish"))
        //{
        //    Destroy(gameObject);
        //    finish.SetActive(true);
        //}


    }
}
