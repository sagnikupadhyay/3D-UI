using UnityEngine;
using UnityEngine.UI;
using SlimUI.ModernMenu;

namespace SRock
{
    public enum Theme {custom1 = 0, custom2 = 1, custom3 = 2 }

    [System.Serializable]
    public class MenuAudio
    {
        public AudioSource hoverSound;
        public AudioSource sliderSound;
        public AudioSource swooshSound;
    }

    [System.Serializable]
    public class MenuView
    {
        public GameObject gameOptions;
        public GameObject playOptions;
        public GameObject settingsOptions;
        public GameObject extrasOptions;
        public GameObject exitOptions;        
    }

    public class MainMenu : MonoBehaviour
    {        
        public MenuView _menuView;
        public MenuAudio _menuAudio;

        [SerializeField] private Animator cameraAnimator;
        [SerializeField] private Theme theme;
        [SerializeField] private FlexibleUIData themeController;

        void Start()
        {            
            _menuView.playOptions.SetActive(false);
            _menuView.settingsOptions.SetActive(false);
            _menuView.exitOptions.SetActive(false);
            _menuView.extrasOptions.SetActive(false);
            _menuView.gameOptions.SetActive(true);

            switch (theme)
            {
                case Theme.custom1: {
                        themeController.currentColor = themeController.custom1.graphic1;
                        themeController.textColor = themeController.custom1.text1; 
                        break; 
                    }
                case Theme.custom2: {
                        themeController.currentColor = themeController.custom2.graphic2;
                        themeController.textColor = themeController.custom2.text2; 
                        break; 
                    }
                case Theme.custom3: {
                        themeController.currentColor = themeController.custom3.graphic3;
                        themeController.textColor = themeController.custom3.text3; 
                        break; 
                    }
            }
        }

        public void Open_PlayOptions()
        {            
            _menuView.settingsOptions.SetActive(false);
            _menuView.extrasOptions.SetActive(false);
            _menuView.exitOptions.SetActive(false);

            _menuView.playOptions.SetActive(true);
        }

        public void Close_PlayOptions()
        {
            _menuView.settingsOptions.SetActive(false);
            _menuView.extrasOptions.SetActive(false);
            _menuView.exitOptions.SetActive(false);

            _menuView.gameOptions.SetActive(true);
        }

        public void Open_SettingsOptions()
        {            
            _menuView.playOptions.SetActive(false);
            _menuView.extrasOptions.SetActive(false);
            _menuView.exitOptions.SetActive(false);

            _menuView.settingsOptions.SetActive(true);
        }

        public void Close_SettingsOptions()
        {
            _menuView.playOptions.SetActive(false);
            _menuView.extrasOptions.SetActive(false);
            _menuView.exitOptions.SetActive(false);

            _menuView.gameOptions.SetActive(true);
        }

        public void Toggle_ExitOptions()
        {
            if (!_menuView.exitOptions.activeSelf)
            {
                _menuView.extrasOptions.SetActive(false);
                _menuView.exitOptions.SetActive(true);
            }
            else
            {
                _menuView.exitOptions.SetActive(false);
            }
        }

        public void Toggle_ExtrasOptions()
        {
            if (!_menuView.extrasOptions.activeSelf)
            {
                _menuView.exitOptions.SetActive(false);
                _menuView.extrasOptions.SetActive(true);
            }
            else
            {
                _menuView.extrasOptions.SetActive(false);
            }
        }

        public void SetPosition1()
        {
            cameraAnimator.SetFloat("Animate", 0);
        }

        public void SetPosition2()
        {
            cameraAnimator.SetFloat("Animate", 1);
        }

        public void PlayHoverSound()
        {
            _menuAudio.hoverSound.Play();
        }

        public void PlaySFXSliderSound()
        {
            _menuAudio.sliderSound.Play();
        }

        public void PlaySwooshSound()
        {
            _menuAudio.swooshSound.Play();
        }

        public void Increase_UIButton(Button button)
        {
            button.transform.localScale = button.transform.localScale * 1.1f;
        }

        public void Decrease_UIButton(Button button)
        {
            button.transform.localScale = button.transform.localScale / 1.1f;
        }
    }
}
