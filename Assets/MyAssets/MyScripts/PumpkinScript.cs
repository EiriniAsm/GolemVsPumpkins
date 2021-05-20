using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class PumpkinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.y < -3f)
        {
            Addressables.ReleaseInstance(gameObject);
        }
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Golem")
        {
            Addressables.ReleaseInstance(target.gameObject);
            Time.timeScale = 0f;
        }
    }

}
