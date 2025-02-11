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
        var y = Mathf.PingPong(Time.time, 6);
        var p = new Vector3(x, y, 0);
        transform.position = p;
        
        //Rotate Target GameObject
        transform.Rotate(new Vector3(30, 60, 0) * Time.deltaTime);
    }
}
