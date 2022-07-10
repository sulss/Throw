using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpma : MonoBehaviour
{
    public GameObject safir, yakut, elmas;
    private void OnCollisionEnter(Collision collision)
    {
        float m = Random.Range(0.0f, 360.0f);
        if (collision.transform.name == "duvar")
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject ySafir = Instantiate(safir, transform.position,
                Quaternion.Euler(m,m,m));
                GameObject yYakut = Instantiate(yakut, transform.position,
                Quaternion.Euler(m,m,m));
                GameObject yElmas = Instantiate(elmas, transform.position,
                Quaternion.Euler(m,m,m));
                Destroy(ySafir, 3);
                Destroy(yYakut, 7);
                Destroy(yElmas, 5);
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
