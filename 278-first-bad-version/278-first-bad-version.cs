/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        if(n == 1 && IsBadVersion(n) )
            return n;
            
       int middleIndex = n/2;
        
       
        
        for(int i = 1 ; i< middleIndex ; i++)
        {
            if(IsBadVersion(i))
            {
               return i; 
            }
        }
        
         if(IsBadVersion(middleIndex))
         return middleIndex;
        
        for(int i = middleIndex+1 ; i <= n ; i++)
        {
            if(IsBadVersion(i))
            {
               return i; 
            }
        }
        
        return -1;
        
        
    }
}