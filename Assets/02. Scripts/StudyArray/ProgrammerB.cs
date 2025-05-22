using devA;
using UnityEngine;

namespace devB 
{
    public class ProgrammerB : MonoBehaviour
    {
        public ProgrammerA pA;

        void Start()
        {
            pA.num2 = 20;
        }
    }    
}