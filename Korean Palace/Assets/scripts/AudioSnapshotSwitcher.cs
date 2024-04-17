using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapshotSwitcher : MonoBehaviour
{
    public AudioMixer audioMixer; // Reference to the Audio Mixer
    public AudioMixerSnapshot normalDay;
    public AudioMixerSnapshot normalNight;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchToSnapshot(normalDay, 1.5f); // Transition time for Alpha1 is 1 second
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchToSnapshot(normalNight, 2.0f); // Transition time for Alpha2 is 2 seconds
        }
    }

    private void SwitchToSnapshot(AudioMixerSnapshot snapshot, float transitionTime)
    {
        snapshot.TransitionTo(transitionTime); // Transition to the specified snapshot with the specified transition time
    }
}
//in this Script, we define public variables for the Audio Mixer that we are reffering to, as well as one each for the snapshots that we will be using.
//remember when replacing the AudioMixerSnapshot names, or adding more, that the names in the update section need to be adjusted.  Furthermore,
//