using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fırlat : MonoBehaviour
{
    public GameObject sandık;
    Vector3 fırlatma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float range = Random.Range(0.0f, 360.0f);
            fırlatma = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, 5));
            GameObject newSandık = Instantiate(sandık, fırlatma, Quaternion.Euler(range, range, range));
            newSandık.GetComponent<Rigidbody>().AddForce(0, 0, 50f, ForceMode.Impulse);
            Destroy(newSandık, 3);
        }
    }
}
