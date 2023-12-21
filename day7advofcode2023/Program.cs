string filepath = "input.txt";
string[] lines = File.ReadAllLines(filepath);
List<Hand> listOfHands = new();   
Dictionary<char, int> cardRanks = new()
        {
            {'A', 13},
            {'K', 12},
            {'Q', 11},
            {'J', 10},
            {'T', 9},
            {'9', 8},
            {'8', 7},
            {'7', 6},
            {'6', 5},
            {'5', 4},
            {'4', 3},
            {'3', 2},
            {'2', 1}
        };

foreach (string line in lines)
{
    int bid = int.Parse(line.Split(" ")[1]);
    string hand = (line.Split(" ")[0]);
    char[] meinHand = hand.ToCharArray();
    
    Hand myHand = new();
    
    myHand.FirstCard = meinHand[0];
    myHand.SecondCard = meinHand[1];
    myHand.ThirdCard = meinHand[2];
    myHand.FourthCard = meinHand[3];
    myHand.FifthCard = meinHand[4];
    
    
    
    
}
int i = 0;

// int typeChecker(in Hand newHand, out int type)
{

}
public class Hand
{
    // public int typeChecker(in Hand newHand, out int type)
    
   
    

    public char FirstCard { get; set; }
    public char SecondCard { get; set; }
    public char ThirdCard { get; set; }
    public char FourthCard { get; set; }
    public char FifthCard { get; set; }
    
    
   
}
