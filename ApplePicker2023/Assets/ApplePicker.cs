using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPreFab;
    public int numBackets = 3;
    public float basketbottomY = -14f;
    public float basketSpacingY = 2f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < numBackets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPreFab);
            Vector3 pos = Vector3.zero;
            pos.y = basketbottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
