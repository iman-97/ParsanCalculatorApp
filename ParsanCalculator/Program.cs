GetInput();

static void GetInput()
{
    Console.WriteLine("Enter your expression:");
    var input = Console.ReadLine();

    CheckInput(input);
}

static void CheckInput(string inputData)
{
    if (string.IsNullOrEmpty(inputData) == true)
    {
        Console.WriteLine("please input something");
        inputData = Console.ReadLine();
        CheckInput(inputData);
    }
    else
    {
        Console.WriteLine(Evaluate(inputData));
        GetInput();
    }
}

static double Evaluate(String expr)
{
    var stack = new Stack<String>();

    var value = "";
    for (int i = 0; i < expr.Length; i++)
    {
        var s = expr.Substring(i, 1);
        var chr = s.ToCharArray()[0];

        if (char.IsDigit(chr) == false && chr != '.' && value != "")
        {
            stack.Push(value);
            value = "";
        }

        if (s.Equals("(") == true)
        {

            var innerExp = "";
            i++;
            var bracketCount = 0;
            for (; i < expr.Length; i++)
            {
                s = expr.Substring(i, 1);

                if (s.Equals("(") == true)
                    bracketCount++;

                if (s.Equals(")") == true)
                    if (bracketCount == 0)
                        break;
                    else
                        bracketCount--;

                innerExp += s;
            }

            stack.Push(Evaluate(innerExp).ToString());
        }
        else if (s.Equals("+") == true)
            stack.Push(s);
        else if (s.Equals("-") == true)
            stack.Push(s);
        else if (s.Equals("*") == true)
            stack.Push(s);
        else if (s.Equals("/") == true)
            stack.Push(s);
        else if (s.Equals("sqrt") == true)
            stack.Push(s);
        else if (s.Equals(")") == true)
        {
        }
        else if (char.IsDigit(chr) == true || chr == '.')
        {
            value += s;

            if (value.Split('.').Length > 2)
                throw new Exception("Invalid decimal.");

            if (i == (expr.Length - 1))
                stack.Push(value);

        }
        else
            throw new Exception("Invalid character.");
    }

    double result = 0;
    while (stack.Count >= 3)
    {
        var right = Convert.ToDouble(stack.Pop());
        var op = stack.Pop();
        var left = Convert.ToDouble(stack.Pop());

        if (op == "+")
            result = left + right;
        else if (op == "+")
            result = left + right;
        else if (op == "-")
            result = left - right;
        else if (op == "*")
            result = left * right;
        else if (op == "/")
            result = left / right;

        stack.Push(result.ToString());
    }

    return Convert.ToDouble(stack.Pop());
}