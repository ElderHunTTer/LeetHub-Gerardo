// public class Solution {
//     public bool IsValid(string s) {
//             string res1 = "(";
//             string res2 = ")";
//             string res3 = "[";
//             string res4 = "]";
//             string res5 = "{";
//             string res6 = "}";
//             string char1;
//             string char2;
//         for(int i = 0; i < s.Length; i += 2)
//         {
//             int firstChar = i;
//             int secondChar = i + 1;
//             int length = 1;

//             char1 = s.Substring(firstChar, length);
//             char2 = s.Substring(secondChar, length);
//             if(char1.Equals(res1)){
//             return (char1.Equals(res1) && char2.Equals(res2));
//             }
//             else if(char1.Equals(res3)){
//             return (char1.Equals(res3) && char2.Equals(res4));
//             }
//             else if(char1.Equals(res5)){
//             return (char1.Equals(res5) && char2.Equals(res6));
//             }
            
//             else{
                
//                 return false;
//             }

            
//         }
            
//     }
    public class Solution {
    public bool IsValid(string s) {
        // Get ready initial state (enforce element type)
        var k = new Stack<char>();
        // Evaluate each character for potential mismatch 
        foreach(char c in s) {
            // Push closing round bracket onto the stack
            if (c == '(') { k.Push(')'); continue; }
            // Push closing curly bracket onto the stack
            if (c == '{') { k.Push('}'); continue; }
            // Push closing square bracket onto the stack
            if (c == '[') { k.Push(']'); continue; }
            // Look out for imbalanced strings or mismatches
            if (k.Count == 0 || c != k.Pop()) return false;
        }
        // Empty stack means string is valid and invalid otherwise
        return k.Count == 0;
    }
}
