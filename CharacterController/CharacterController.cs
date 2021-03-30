using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int vitesseDeplacement = 10;

    public int sourisSensibilite = 100;
    private float sourisX, sourisY;

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Gestion des déplacements :
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime * vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1 * Time.deltaTime * vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1 * Time.deltaTime * vitesseDeplacement, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1 * Time.deltaTime * vitesseDeplacement, 0, 0);
        }


        sourisX += Input.GetAxis("Mouse X") * sourisSensibilite * Time.deltaTime;

        transform.eulerAngles = new Vector3(0, sourisX, 0);

        sourisY = -Input.GetAxis("Mouse Y");

        camera.transform.Rotate(sourisY, 0,0);
    }
}
