/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int start = 1;
       while(start < n)
       {
           int middleValue = start + (n- start)/2;
            if(IsBadVersion(middleValue))
                n = middleValue;
            else
                start = middleValue + 1;
        }
            return start;
       }
    }