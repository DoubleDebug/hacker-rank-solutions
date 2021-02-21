#include <string>
#include <iostream>
#include <algorithm>
#include <stack>
using namespace std;


int main() {
    
    string s = "";
    stack<string> stack;
    stack.push(s);
    int n;
    cin >> n;
    
    for (int i=0; i<=n; i++)
    {
        string op;
        getline(cin, op);
        
        if (op[0] == '1')
        {
            // append
            s.append(op.substr(2, op.length() - 2));
            stack.push(s);
        }
        else if (op[0] == '2')
        {
            // delete
            s = s.substr(0, s.length() - stoi(op.substr(2, op.length() - 2)));
            stack.push(s);
        }
        else if (op[0] == '3')
        {
            // print
            cout << s[stoi(op.substr(2, op.length() - 2)) - 1] << endl;
        }
        else if (op[0] == '4')
        {
            // undo
            stack.pop();
            s = stack.top();
        }
    }
    
    return 0;
}
