using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int vitesseDeplacement = 10;

    public int sourisSensibilite = 100;
    private float rotationCameraX, rotationY;

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Notes :
         * On compare tout le temps la valeur de déplacement des objets ou du déplacement de la souris par 
         * le temps depuis le dernier passage dans la fonction Update avec la classe Time.deltaTime afin qu'en
         * fonction du nombre d'image par seconde d'un joueur sur le jeu, son déplacement soit oujours le même
         * pour une personne qui a moins d'images par seconde.
         */

        /*
         * Gestion des déplacements 
         */
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime * vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1 * Time.deltaTime * vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-1 * Time.deltaTime * vitesseDeplacement, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * Time.deltaTime * vitesseDeplacement, 0, 0);
        }



        /*
         * Code pour que l'objet qui possède le script et ce qui 
         * le compose (comme une caméra) fasse une rotation en Y :
         */
        rotationY += Input.GetAxis("Mouse X") * sourisSensibilite * Time.deltaTime;         //Récupérer la valeur du déplacement de la souris en X.
        transform.localRotation = Quaternion.Euler(0, rotationY, 0);                        //Affecter le déplacement de la souris en X sur la rotation Y de l'objet possèdent le script


        /*
         * Code pour la rotation de la caméra uniquement sur l'axe X :
        */
        rotationCameraX += -Input.GetAxis("Mouse Y") * sourisSensibilite * Time.deltaTime;  //Récupérer la valeur du déplacement de la souris en Y.
        rotationCameraX = Mathf.Clamp(rotationCameraX, -90f, 90f);                          //Bloquer la valeur de rotation entre -90 et 90°.
        camera.transform.localRotation = Quaternion.Euler(rotationCameraX, 0, 0);           //Affecter le déplacement de la souris en Y sur la rotation Y de la caméra

    }
}
