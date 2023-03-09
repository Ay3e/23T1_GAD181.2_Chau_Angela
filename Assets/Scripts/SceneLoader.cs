using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AngelaChau
{
    public class SceneLoader : MonoBehaviour
    {
        //private int piratePick = 0;
        private int pirateDeclare = 1;
        private int captainCheckIn = 2;
        //goodID includes FishID:0, CoconutsID: 1
        public static int goodID = 0;

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
    }
}