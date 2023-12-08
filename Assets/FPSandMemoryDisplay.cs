using UnityEngine;

public class FrameRateAndMemoryDisplay : MonoBehaviour
{
    public float timer, refresh, avgFramerate;
    private float memoryUsage;

    private void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;
        if(timer <=0) avgFramerate = (int) (1f / timelapse);
        memoryUsage = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong() / 1024.0f / 1024.0f ;

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Frame rate: " + avgFramerate.ToString());
        GUI.Label(new Rect(10, 30, 200, 20), "Memory usage: " + memoryUsage.ToString() + " MB");
    }
}
