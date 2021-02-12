int getTotalX(vector<int> a, vector<int> b) {
    int maxA = *max_element(a.begin(), a.end());
    int maxB = *max_element(b.begin(), b.end());
    int end = max(maxA, maxB);
    int count = 0;
    
    for (int i=1; i<=end; i++)
    {
        bool cond = true;
        for (int j=0; j<a.size(); j++)
        {
            if (i % a[j] != 0)
            {
                cond = false;
                break;
            }
        }
        
        for (int j=0; j<b.size(); j++)
        {
            if (b[j] % i != 0)
            {
                cond = false;
                break;
            }
        }
        
        if (cond)
            count++;
    }
    
    return count;
}
