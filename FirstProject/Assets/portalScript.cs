using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class portalScript : MonoBehaviour
{
    public int Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 50f * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(Scene);
    }
}
