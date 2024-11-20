using UnityEngine;

public class DynamicCameraSize : MonoBehaviour
{
    public float baseOrthographicSize = 5f; // Base size you want for a specific aspect ratio
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        AdjustCameraSize();
    }

    void Update()
    {
        AdjustCameraSize();
    }

    void AdjustCameraSize()
    {
        float targetAspect = 16f / 9f; // Reference aspect ratio (e.g., 16:9)
        float currentAspect = (float)Screen.width / Screen.height;
        cam.orthographicSize = baseOrthographicSize * (targetAspect / currentAspect);
    }
}