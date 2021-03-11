using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerV1 : MonoBehaviour
{
    static int vitesseMarche = 10;
    static int vitesseCourse = 30;

    static int vitesseRotation = 100;

    static float avancer;
    static float rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avancer = Input.GetAxis("Vertical") * vitesseMarche * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * vitesseRotation * Time.deltaTime;

        if (Input.GetKey("z"))
            transform.Translate(0, 0, avancer);
    }
}
