using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

    public class OptionsMenu : MonoBehaviour
    {
        public AudioMixer audioMixer;

        [SerializeField] private Button buttonClose;

        public void Awake()
        {
            buttonClose.onClick.AddListener(() => this.gameObject.SetActive(false));
        }
        public void SetVolume (float volume)
        {
            audioMixer.SetFloat("volume", volume);
        }

        public void SetFullScreen (bool isFullScreen)
        {
            Screen.fullScreen = isFullScreen;
        }
    }