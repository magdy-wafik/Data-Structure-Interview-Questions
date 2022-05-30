/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int startValue = 1;
       while(startValue < n)
       {
           int middleValue = startValue + (n - startValue)/2;
            if(IsBadVersion(middleValue))
                n = middleValue;
            else
                startValue = middleValue + 1;
        }
            return startValue;
       }
    }