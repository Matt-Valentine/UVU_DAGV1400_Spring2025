using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the Target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        transform.position = p;
        
        //Rotate Target GameObject
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
