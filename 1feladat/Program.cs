//1.feladat 

using _1feladat;

List<TEXT> text = new List<TEXT>();
string[] txt = File.ReadAllLines("nyeremenyek.txt");
foreach (var item in txt)
{
    string[] values = item.Split(';');
    TEXT items_object = new TEXT(int.Parse(values[0]), values[1], int.Parse(values[2]), values[3], values[4]);
    text.Add(items_object);
}

/*foreach (var item in text)
{
    Console.WriteLine($"{item.id} {item.name} price: {item.price} times: {item.times} nyertes: {item.nyertese}");
}*/

Console.WriteLine("2. feladat");
Console.WriteLine("Adj mege gy ID-t");

string input_id = Console.ReadLine();
int int_inputid = int.Parse(input_id);

foreach (var item in text)
{
    if (item.id == int_inputid)
    {
        Console.WriteLine($"Sorszám: {item.id}, Név: {item.name}, nyeremény: {item.price}, alkalom: {item.times}, nyert-e: {item.nyertese}");
    }
}
Console.WriteLine("3.feladat");

string mostFrequentName = null;
int maxCount = 0;
int sum = 0;

foreach (var item in text)
{
    int count = 0;
    int priceSum = 0;

    foreach (var otherItem in text)
    {
        if (otherItem.name == item.name)
        {
            count++;
            priceSum += otherItem.price;
        }
    }

    if (count > maxCount)
    {
        maxCount = count;
        mostFrequentName = item.name;
        sum = priceSum;
    }
}

Console.WriteLine($"A legtöbb nyereményt {mostFrequentName} névre nyerték, összesen {maxCount} alkalommal, a nyertes össznyereménye {sum} forint.");

Console.WriteLine("4. feladat");
int nyertdb = 0;
List<int> nyertesek = new List<int>();
foreach (var item in text)
{
    if (item.nyertese == "nyertes")
    {
        nyertdb++;
        nyertesek.Add(item.id);
    }
}
Console.WriteLine($"Ennyi játszma lett nyerve: {nyertdb} ");
Console.WriteLine("5. feladat");

TEXT lowestPriceItem = null;

foreach (var item in text)
{
    if (lowestPriceItem == null || item.price < lowestPriceItem.price)
    {
        lowestPriceItem = item;
    }
}

Console.WriteLine($"A legkisebb nyereményt {lowestPriceItem.name} névvel rendelkező személy nyerte, a nyeremény összege: {lowestPriceItem.price} forint.");

Console.WriteLine("6. feladat");

var namesStartingWithA = text
    .Where(item => item.name.StartsWith("a"))
    .Select(item => item.name)
    .Take(5)
    .ToList();

Console.WriteLine("Az 'a'-val kezdődő nevek:");
foreach (var name in namesStartingWithA)
{
    Console.WriteLine(name);
}

foreach (var item in text)
{
    foreach (var item2 in nyertesek)
    {
        if (item.id == item2)
        {
            Console.WriteLine($"Nyertes neve: {item.name}, Sorszáma: {item.id}, nyeremény: { item.price}");
        }
    }
}




