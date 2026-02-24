using UnityEngine;

public class rain_script : MonoBehaviour
{
    float y_scale;
    public int flow_speed = 10;
    float internal_flow_speed;
    Vector3 rain_pos = Vector3.zero;
    void Start()
    {
        born();    
    }

    void Update()
    {
       move();
        if (rain_pos.y < -6f) 
        {
           born();
        }
    }


    void born() 
    {
        y_scale = Random.Range(0f, 1f);
        internal_flow_speed = Random.Range(0.8f, 1f);
        GetComponent<Renderer>().material.color = new Color(0.8f/y_scale, 0.2f/y_scale, 0.8f/y_scale, 1f*y_scale);
        gameObject.transform.localScale = new Vector3(0.5f*y_scale, 0.5f*y_scale, 1f);
        rain_pos.x = Random.Range(-9.2f,9.2f);
        rain_pos.y = Random.Range(5f,15f);
        rain_pos.z = (y_scale-0.5f)*-7f;
        transform.position = rain_pos;

    }

    void move() 
    {
        rain_pos.y += -0.0005f*flow_speed*internal_flow_speed;
        transform.position = rain_pos;
    }
}
