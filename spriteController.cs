using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spriteController : MonoBehaviour
{
    Transform cube_tr;
    int score = 100;
    // Start is called before the first frame update
    void Start()
    {
        cube_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("w"))
        {
            cube_tr.Translate(0,0,1f);
        } 
        if (Input.GetKeyDown("a"))
        {
            cube_tr.Translate(-1f,0,0);
        } 
        if (Input.GetKeyDown("s"))
        {
            cube_tr.Translate(0,0,-1f);
        } 
        if (Input.GetKeyDown("d"))
        {
            cube_tr.Translate(1f,0,0);
        } 
        if(score == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "enemy")
        {
            //print("в нас попали!");
            score = score - 20;
            print(score);
        }
    }
    
}
