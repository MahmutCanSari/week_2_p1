using UnityEngine;

public class rain_spawner_script : MonoBehaviour
{
    public GameObject rain;
    public int rain_count;
    void Start()
    {
        for (int i = 0; i <= rain_count; i++) 
        {
            Instantiate(rain);
        }

    }

}
