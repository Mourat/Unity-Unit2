using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TopBound = 40f;
    private const float LowerBound = -20f;

    private void Update()
    {
        var pos = transform.position;
        if (pos.z > TopBound || pos.z < LowerBound)
            Destroy(gameObject);
    }
}
