/* Skriv ut "SNAKE" baklänges
 const string input = "SNAKE";

for(int i = input.Length-1; i >= 0; i--)
{
    Console.Write(input[i]);
}
*/

const string input = "SNAKE";
Stack<char> stack = new Stack<char>();
foreach(char c in input)
{
    stack.Push(c);
}

while(stack.Count != 0)
{
    Console.Write(stack.Pop());
}