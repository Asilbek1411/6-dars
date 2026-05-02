// 1+1
// 2
// Bir xonali 2 ta son kiritilganda ixtiyoriy natijasini ekranga chiqarish kerak !


Console.WriteLine(" Biron bir Arimetik amal bajaring ! \n\t Misol:");
string misol = Console.ReadLine();
char son1 = misol[0];
int intson1 = Convert.ToInt32(son1.ToString());
char son2 = misol[2];
int intson2 = Convert.ToInt32(son2.ToString());
char aperator1 = misol[1];

switch(aperator1)
    {

    case '+':
        Console.WriteLine(intson1 + intson2);
        break;
    
    case'-' :
        Console.WriteLine(intson1 - intson2);
        break;

    case '/' :
        Console.WriteLine(intson1 / intson2);
        break;

    case '*' :
        Console.WriteLine(intson1 * intson2);
        break;
    
    }