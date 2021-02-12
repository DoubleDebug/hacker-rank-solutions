vector<int> climbingLeaderboard(vector<int> ranked, vector<int> player) {
    vector<int> result(player.size());
    vector<int> leaderboard(ranked.size() + 1);
    
    leaderboard[0] = 1;
    for (int i=1; i < ranked.size(); i++)
    {
        if (ranked[i] == ranked[i - 1])
            leaderboard[i] = leaderboard[i - 1];
        else
            leaderboard[i] = leaderboard[i - 1] + 1;
    }
    
    int j = ranked.size() - 1;
    for (int i=0; i < player.size(); i++)
    {
        while (j >= 0 && ranked[j] < player[i])
            j--;
            
        if (j >= 0)
        {
            if (player[i] < ranked[j])
                result[i] = leaderboard[j] + 1;
            else
                result[i] = leaderboard[j];
        }
        else
            result[i] = 1;
    }
    
    return result;
}
