using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]

    // prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which the apple moves
    public float speed = 6f;

    // Distance at which the apple tree turns around
    public float leftAndRightEdge = 11f;

    //chance that the apple tree will change direction
    public float changeDirChance = 0.001f;

    //seconds between apple drops
    public float appleDropDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        //start dropping apples
        Invoke("DropApple", 2f);

    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing direction
        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move Right
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move Left
        }

    }
    void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1; //Change Direction
        }
    }
}
