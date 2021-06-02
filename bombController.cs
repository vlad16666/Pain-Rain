using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    float x;
    float z;
    float y;
    Transform enemy_tr;
    // Start is called before the first frame update
    void Start()
    {
        enemy_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "ground" )
        {
            x = Random.Range(-8.7f,5f);
            z = Random.Range(-19f,8f);
            y = Random.Range(20f,25f);
            Instantiate(gameObject,new Vector3(x,y,z),enemy_tr.rotation);
            Destroy(gameObject);
        }
    }
}
