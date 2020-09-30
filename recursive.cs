private int f(int[] y, int lastindex)
{
if (lastindex < 0)
return 0;
else
return y[lastindex] + f(y, lastindex-1);
}
private void main()
{
int[] x = new int[6]{1, 2, 3, 4, 5, 6};
int answer = f(x, 5);
Console.WriteLine( answer.ToString() );
}