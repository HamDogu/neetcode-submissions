public class Solution {
    public bool IsPalindrome(string s) {
        s = System.Text.RegularExpressions.Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        s = s.Replace(" ", "");
        for(int i = 0; i < s.Length; i++) {
            char j = s[s.Length - 1 - i];
            if(j == s[i]){
                continue;
            } else {
                return false;
            }
        }
        return true;
    }
}
