import time
import os

def clear():
    if os.name == 'nt':
        os.system('cls')
    else:
        os.system('clear')

def scroll_text(text, delay):
    for i in range(len(text)):
        clear()
        print(text[i:i+80])
        time.sleep(delay)

code = '''
/* Begin hack */
#include <iostream>
#include <string>
using namespace std;

int main()
{
    string secret = "HIDDEN";
    string password;

    cout << "Enter the password to access the secret: ";
    cin >> password;

    if (password == secret)
    {
        cout << "Access granted. The secret is: " << secret << endl;
    }
    else
    {
        cout << "Access denied." << endl;
    }

    return 0;
}
/* End hack */
'''

scroll_text(code, 0.05)