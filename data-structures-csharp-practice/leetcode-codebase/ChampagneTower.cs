public class ChampagneTower 
{
    public double ChampagneTower(int poured, int query_row, int query_glass) 
    {
        
        double[] current = new double[1];
        current[0] = poured;
        
        for (int row = 0; row < query_row; row++) {
            double[] next = new double[row + 2];
            
            for (int i = 0; i <= row; i++) {
                if (current[i] > 1.0) {
                    double overflow = (current[i] - 1.0) / 2.0;
                    next[i] += overflow;
                    next[i + 1] += overflow;
                }
            }
            current = next;
        }
        
        return Math.Min(1.0, current[query_glass]);
    }
}