using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exe_1 : MonoBehaviour
{
    void Start()
    {
        using UnityEngine;

public class Exe1 : MonoBehaviour
    {
        string line = "ajdfajAdjhfAahhAj;aj 0 ;aknkjfbAAnjj";

        private void Start()
        {
            int countAa = 0;
            int Length = 0;

            foreach (char simvol in line)
            {
                if (simvol == '0')
                {
                    Debug.Log($"Zero is contained in {Length}");
                    break;
                }


                if (simvol == 'a' || simvol == 'A')
                {
                    countAa++;
                }
                Length++;
            }
            print($"Number of characters a and A: {countAa}");
            Debug.Log($"line length: {Length}");
        }
    }
}


