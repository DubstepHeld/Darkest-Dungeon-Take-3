using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global {

    /*
     * Es gibt verschiedene Faktoren, die die Stats eines Characters beeinflussen.
     * 
     * 1) Eine Charakterklasse hat gewisse Grundwerte
     * 2) Zu Anfang eines Kampfes werden die Werte zufällig ein wenig verändert
     * 3) Der globale Skillbaum beinhaltet Skillverbesserungen
     * 4) Statuseffekte beeinflussen die Werte
     * 
     * Punkte 1 bis 4 werden addiert und ergeben so die endgültigen Werte für die Stats.
     * In StatsUtil.StatsForRace werden Punkte 1 und 2 berechnet.
     */

    public struct Stats {

        public int maxHealth;
        public int damage;
        public float hitChance;
        public int dodge;
        public int initiative;

        // Resistance agains stuff
        public float blightRes;
        public float bleedRes;
        public float stunRes;

    }

    public static class StatsUtil {

        // Returns randomly modified base stats for the race.
        // The skill tree and buffs can now modify those stats.
        public static Stats StatsForRace(Race race) {
            Stats stats = BaseStats(race);
            return RandomlyModify(race, stats);
        }

        public static Stats BaseStats(Race race) {
            Stats stats = new Stats();
            switch (race) { // TODO: Add all races here
                case Race.Support:
                    stats.maxHealth = 9;
                    stats.damage = 3;
                    stats.hitChance = 0.90f;
                    stats.dodge = 5;
                    stats.initiative = 10;
                    stats.blightRes = 0.70f;
                    stats.bleedRes = 0.70f;
                    stats.stunRes = 0.60f;
                    break;
            }
            return stats;
        }

        public static Stats RandomlyModify(Race race, Stats stats) {
            switch (race) { // TODO: Add all races here
                case Race.Support:
                    stats.maxHealth += Util.RollDice(3);
                    stats.dodge += Util.RollDice(6);
                    break;
            }
            return stats;
        }

    }

}
