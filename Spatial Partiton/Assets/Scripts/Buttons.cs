using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpatialPartitionPattern
{

    public class Buttons : MonoBehaviour
    {
        GameController game = new GameController();

        public void Add()
        {
            game.AddSoldiers();
        }

        public void Subtract()
        {
            game.RemoveSoldiers();
        }
    }
}
