public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> map = new Dictionary<char, char>() {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            Console.WriteLine("c: " + c);
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) {
                    Console.WriteLine(" - Not valid");
                    return false;
                }
                char peeker = stack.Peek();
                
                if (peeker == map[c]) {
                    stack.Pop();
                } else {
                    Console.WriteLine(" - Not valid");
                    return false;
                }
            }
        }
        if (stack.Count == 0) {
            return true;
        }
        Console.WriteLine(" - Not valid");
        return false;
    }
}
