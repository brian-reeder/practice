public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        
        if(coordinates.Length == 2)
            return true;

        int rise, run, tRise, tRun;
        decimal? slope, tSlope;
        // Y-axis
        rise = coordinates[0][1] - coordinates[1][1];
        // X-axis
        run  = coordinates[0][0] - coordinates[1][0];
        
        slope = (run == 0) ? null:(decimal) rise/run;
        for(int i = 1; i < coordinates.Length; i++) {
            tRise = coordinates[i-1][1] - coordinates[i][1];
            tRun  = coordinates[i-1][0] - coordinates[i][0];
            tSlope = (tRun == 0)? null:(decimal) tRise / tRun;
            if(tSlope != slope)
                return false;
        }
        
        return true;   
    }
}