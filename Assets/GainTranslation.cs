using UnityEngine;

public class GainTranslation: MonoBehaviour
{
    void Start()
    {
        transform.Translate(transform.localPosition*2);
    }
}
