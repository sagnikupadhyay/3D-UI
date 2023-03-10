using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRock
{
    [System.Serializable]
    public class SettingsData
    {
        //settings panels
        public GameObject PanelGame;
        public GameObject PanelControls;
        public GameObject PanelSound;
        public GameObject PanelVideo;        
        public GameObject PanelKeyBindings;

        //settings subpanels
        public GameObject SubPanelMovement;
        public GameObject SubPanelCombat;
        public GameObject SubPanelGeneral;

        //settings highlighters
        public GameObject lineGamePanel;
        public GameObject lineVideoPanel;
        public GameObject lineControlsPanel;
        public GameObject lineKeyBindingsPanel;
        public GameObject lineMovementSubPanel;
        public GameObject lineCombatSubPanel;
        public GameObject lineGeneralSubPanel;
    }

    public class SettingsOptions : MonoBehaviour
    {
        public SettingsData _settingsData;

        private void DisableAllPanelsAndHighlighters()
        {
            _settingsData.PanelControls.SetActive(false);
            _settingsData.PanelVideo.SetActive(false);
            _settingsData.PanelGame.SetActive(false);
            _settingsData.PanelKeyBindings.SetActive(false);

            _settingsData.SubPanelMovement.SetActive(false);
            _settingsData.SubPanelCombat.SetActive(false);
            _settingsData.SubPanelGeneral.SetActive(false);

            _settingsData.lineGamePanel.SetActive(false);
            _settingsData.lineControlsPanel.SetActive(false);
            _settingsData.lineVideoPanel.SetActive(false);
            _settingsData.lineKeyBindingsPanel.SetActive(false);
            _settingsData.lineMovementSubPanel.SetActive(false);
            _settingsData.lineCombatSubPanel.SetActive(false);
            _settingsData.lineGeneralSubPanel.SetActive(false);
        }

        public void Open_GamePanel()
        {
            DisableAllPanelsAndHighlighters();
            _settingsData.PanelGame.SetActive(true);
            _settingsData.lineGamePanel.SetActive(true);
        }

        public void Open_VideoPanel()
        {
            DisableAllPanelsAndHighlighters();
            _settingsData.PanelVideo.SetActive(true);
            _settingsData.lineVideoPanel.SetActive(true);
        }

        public void Open_ControlsPanel()
        {
            DisableAllPanelsAndHighlighters();
            _settingsData.PanelControls.SetActive(true);
            _settingsData.lineControlsPanel.SetActive(true);
        }

        public void Open_KeyBindingsPanel()
        {
            DisableAllPanelsAndHighlighters();
            Open_MovementSubPanel();
            _settingsData.PanelKeyBindings.SetActive(true);
            _settingsData.lineKeyBindingsPanel.SetActive(true);
        }

        public void Open_MovementSubPanel()
        {
            DisableAllPanelsAndHighlighters();
            _settingsData.PanelKeyBindings.SetActive(true);
            _settingsData.SubPanelMovement.SetActive(true);
            _settingsData.lineMovementSubPanel.SetActive(true);
        }

        public void Open_CombatSubPanel()
        {
            DisableAllPanelsAndHighlighters();
            _settingsData.PanelKeyBindings.SetActive(true);
            _settingsData.SubPanelCombat.SetActive(true);
            _settingsData.lineCombatSubPanel.SetActive(true);
        }

        public void Open_GeneralSubPanel()
        {
            DisableAllPanelsAndHighlighters();
            _settingsData.PanelKeyBindings.SetActive(true);
            _settingsData.SubPanelGeneral.SetActive(true);
            _settingsData.lineGeneralSubPanel.SetActive(true);
        }
    }
}
