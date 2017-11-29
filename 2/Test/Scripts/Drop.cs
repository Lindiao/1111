using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    public float delay = 1;

    IEnumerator Start() {
        yield return new WaitForSeconds(delay);
        GetComponent<Animation>().Play();
    }

}
