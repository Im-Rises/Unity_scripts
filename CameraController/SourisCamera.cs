using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourisCamera : MonoBehaviour
{
    public int sourisSensibilite = 100;

    private float sourisX, sourisY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sourisX += sourisSensibilite * Input.GetAxis("Mouse X") * sourisSensibilite * Time.deltaTime;
        sourisY += -sourisSensibilite * Input.GetAxis("Mouse Y") * sourisSensibilite * Time.deltaTime;

        transform.eulerAngles = new Vector3(sourisY, sourisX, 0);
    }
}
