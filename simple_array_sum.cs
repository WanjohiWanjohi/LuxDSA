 public static int simpleArraySum(List<int> ar)
    {
        int sum = 0; 
        ar.ForEach(x => sum += x);
        return sum;

    }
