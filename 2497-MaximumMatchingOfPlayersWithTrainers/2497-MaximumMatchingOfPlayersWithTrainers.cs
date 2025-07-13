// Last updated: 7/13/2025, 8:27:44 PM
public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        Array.Sort(players);
        Array.Sort(trainers);
        int playersIndex = 0;
        int trainersIndex = 0;
        int matchCount = 0;
        while (playersIndex<players.Length && trainersIndex<trainers.Length){
           if (players[playersIndex]<= trainers[trainersIndex]){
            playersIndex++;
            trainersIndex++;
            matchCount++;
           } 
           else {
            trainersIndex++;
           }
        }
        return matchCount;
    }
}