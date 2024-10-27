using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class VideoPlayback : MonoBehaviour
{
    private ObserverBehaviour mObserverBehaviour;
    public VideoPlayer videoPlayer; // Asegúrate de que este campo sea público

    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnDestroy()
    {
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            // La imagen ha sido reconocida
            videoPlayer.Play();
        }
        else if (targetStatus.Status != Status.TRACKED)
        {
            // La imagen ha sido perdida
            videoPlayer.Stop();
        }
    }
}