public class BinaryNumberwithAlternatingBits {
    public bool HasAlternatingBits(int n) {
        string s = Convert.ToString(n,2);
        for(int i = 1; i < s.Length; i++){
            if(s[i] == s[i-1]){
                return false;
            }
        }
        return true;
    }
}