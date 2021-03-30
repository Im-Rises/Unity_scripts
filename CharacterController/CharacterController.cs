using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int vitesseMarche = 10;
    public int vitesseCourse = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,1*Time.deltaTime*vitesseMarche);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-1*Time.deltaTime * vitesseMarche);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1*Time.deltaTime * vitesseMarche, 0,0);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1*Time.deltaTime * vitesseMarche, 0,0);
        }
        
    }
}