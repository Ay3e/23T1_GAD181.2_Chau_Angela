using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AngelaChau
{
    public class SceneLoader : MonoBehaviour
    {
        private int piratePick = 1;
        private int pirateDeclare = 2;
        private int captainCheckIn = 3;
        //goodID includes FishID:0, CoconutsID: 1
        public static int goodID = 0;
        private int openTheChest = 4;

        public void PiratePick()
        {
            SceneManager.LoadScene(piratePick);
        }

        public void ButtonToPirateDeclare()
        {
            SceneManager.LoadScene(pirateDeclare);
        }

        public void FishButtonToCaptionCheckIn()
        {
            goodID = 0;
            SceneManager.LoadScene(captainCheckIn);

        }

        public void CoconutsButtonToCaptionCheckIn()
        {
            goodID = 1;
            SceneManager.LoadScene(captainCheckIn);
        }

        //public void CheckDeclared()
        //{
        //    SceneManager.LoadScene();
        //}

        public void OpenTheDeclaredChest()
        {
            SceneManager.LoadScene(openTheChest);
        }
    }
}