public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    //Subtract method
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
	
	//Divide method with check for zero 
	
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}