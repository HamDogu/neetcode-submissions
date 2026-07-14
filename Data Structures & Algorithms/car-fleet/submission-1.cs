public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int fleets = 0;
        int[][] pairs = new int[position.Length][];
        List<(int position, int speed, double time)> list = new();
        
        // double[] times = new double[position.Length];
        for (int i = 0; i < position.Length; i++) {
            // pairs[i] = new int[] { position[i], speed[i] };
            var time = ((double)target - position[i]) / speed[i];
            list.Add((position[i], speed[i], time));
        }
        // Array.Sort(pairs, (a, b) => b[0].CompareTo(a[0]))
        list.Sort((a, b) => b.position.CompareTo(a.position));

        double previousFleetTime = 0;

        foreach (var car in list)
        {
        // A greater time means this car cannot catch the fleet ahead.
        if (car.time > previousFleetTime)
        {
            fleets++;
            previousFleetTime = car.time;
        }

        // Otherwise, this car catches the fleet ahead and is not counted.
    }

        return fleets;
    }
}
