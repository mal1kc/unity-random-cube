using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(Random.Range(-6,10),Random.Range(-7,14),Random.Range(-13,13));
        transform.localScale = Vector3.one * Random.Range(0.0f,5.0f);
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f,1.0001f), Random.Range(0.0f,1.0001f),Random.Range(0.0f,1.0001f), 0.4f);
        InvokeRepeating("RandomChangeColorAndScalePosition",3.0f,2.5f);
    }
    
    void Update()
    {
        transform.Rotate(Random.Range(0.0f,20.0f) * Time.deltaTime, 0.0f, Random.Range(0.0f,0.5f));
    }

    void RandomChangeColorAndScalePosition(){
        transform.position = new Vector3(Random.Range(-6,10),Random.Range(-7,15),Random.Range(-13,13));
        transform.localScale = Vector3.one * Random.Range(0.0f,5.0f);
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f,1.0001f), Random.Range(0.0f,1.0001f),Random.Range(0.0f,1.0001f), 0.4f);
    }
}
