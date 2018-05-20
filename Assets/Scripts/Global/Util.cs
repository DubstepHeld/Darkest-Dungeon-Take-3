using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global {

    public static class Util {

        // RollDice(4) = Random.Range(0, 5)
        // -> [0, 1, 2, 3, 4] as possible values
        public static int RollDice(int max) {
            return Random.Range(0, max + 1); // +1 weil min inclusive und max exclusive
        }

        // RollDice(2, 4) = Random.Range(2, 5)
        // -> [2, 3, 4] as possible values
        public static int RollDice(int min, int max) {
            int value = Random.Range(min, max + 1);
            return value;
        }

    }

}
