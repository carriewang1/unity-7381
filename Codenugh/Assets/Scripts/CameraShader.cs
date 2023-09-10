using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class CameraShader : MonoBehaviour
{
    public float shakeSpeed = 0.2f; // how fast the camera shaking
    public float shakeAmount = 0.05f; // the amplitude of shaking
    public PostProcessVolume postProcessVolume;
    public GameObject player;


    private Vector3 originalPosition;
    private float timer = 0.0f;

    private void Start()
    {
        originalPosition = transform.localPosition;

    }

    private void Update()
    {
        // 在Update中进行摇晃
        timer += Time.deltaTime;
        Vector3 playerPosition = player.transform.position;

        float offsetX = Mathf.PerlinNoise(timer * shakeSpeed, 0) * 2 - 1;
        float offsetY = Mathf.PerlinNoise(0, timer * shakeSpeed) * 1 - 1;

        Vector3 newPosition = originalPosition + new Vector3(offsetX, offsetY, 0) * shakeAmount;
        transform.localPosition = newPosition;
        //启用摇晃
        //postProcessVolume.enabled = Mathf.Abs(offsetX) > 0.1f || Mathf.Abs(offsetY) > 0.1f;
        // 启用或禁用动态模糊效果
        bool enableMotionBlur = true; // 根据需要调整
        postProcessVolume.enabled = enableMotionBlur;
        transform.position = playerPosition + newPosition;

    }
}
