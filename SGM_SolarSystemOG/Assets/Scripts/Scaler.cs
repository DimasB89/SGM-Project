using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

    [SerializeField] private float scaleModifier = 10f;

    public void ScaleUp()
    {
        transform.localScale += new Vector3(scaleModifier, scaleModifier, scaleModifier);
    }

    public void ScaleDown()
    {
        transform.localScale -= new Vector3(scaleModifier, scaleModifier, scaleModifier);
    }
}
