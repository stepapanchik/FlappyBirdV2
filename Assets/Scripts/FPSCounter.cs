using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;

    private float pollingTime = 0.5f;
    private float time;
    private int frameCount;

    void Start()
    {
        QualitySettings.vSyncCount = 0;  
        Application.targetFrameRate = 120;
    }

    void Update()
    {
        time += Time.deltaTime;
        frameCount++;

        if (time >= pollingTime)
        {
            int fps = Mathf.RoundToInt(frameCount / time);
            fpsText.text = $"FPS: {fps}";

            if (fps >= 60)
                fpsText.color = Color.green;
            else if (fps >= 30)
                fpsText.color = Color.yellow;
            else
                fpsText.color = Color.red;

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
