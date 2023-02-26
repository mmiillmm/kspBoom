using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace kspModTest
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class RandomPartExplosion : MonoBehaviour
    {
        public void Update()
        {
            bool gomb = Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha1);

            if (gomb == true)
            {
                List<Part> parts = FlightGlobals.ActiveVessel.parts;

                int index;

                System.Random rnd = new System.Random();

                index = rnd.Next(1, parts.Count);

                parts[index].explode();
            }
        }
    }
}