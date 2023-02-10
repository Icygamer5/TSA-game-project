using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;

/// <summary>
///     Play some satisfying click sounds
/// </summary>
public class ButtonClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    public void OnPointerDown(PointerEventData eventData) {
        PlayClip("Button Up");
    }

    public void OnPointerUp(PointerEventData eventData) {
        PlayClip("Button Down");
    }

    private static void PlayClip(string n) {
        AudioClip clip = Addressables.LoadAssetAsync<AudioClip>(n).WaitForCompletion();
        AudioSource.PlayClipAtPoint(clip, Vector3.zero);
    }
}