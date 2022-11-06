// See https://aka.ms/new-console-template for more information

int iSquareNum = 1;
double dGrainNum = 1;
double dGrainTotal = 0;


do
{
    dGrainTotal += dGrainNum;

    dGrainNum = dGrainNum * 2;

    Console.WriteLine(dGrainTotal);

    iSquareNum++;

    

}
while (iSquareNum < 65);

Console.Read();
