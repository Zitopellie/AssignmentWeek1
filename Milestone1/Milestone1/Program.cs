
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
{
    
    
   

    #region 1
    /* Create a Console Application to Print to the console A fictitious firm record.
 * The record would have the following characteristics 
 * – Company name, Company Industry, Company Location,
 * Company Mission, Company Vision and the Company CEO. */


    string companyName = "HackCity" , companyIndustry = "Tech" , companyLocation = "Lagos" ,
        companyMission = " training tech geniuses" , companyVission = " becoming the best " ,
        companyCeo = "mr Shola";

    Console.WriteLine("Company name, Company Industry, Company Location, Company Mission, Company Vision and the Company CEO is: \n" + "\n" + companyName +
        "\n" +companyIndustry + "\n" + companyLocation + "\n" + companyMission + "\n" + companyVission + "\n" + companyCeo + "\n" + "respectively");

    #endregion

    #region 2
    /* Declare five variables choosing for each of them the most appropriate of the types byte,
     * sbyte, short, ushort, int, uint, long, ulong to represent the following values
     * : 52130, -115, 4825932, 97, -10000 */

    int a = 52130;
    sbyte b = -115;
    int c = 4825932;
    sbyte d = 97;
    short e = -10000;

    #endregion

    #region 3

    /* A marketing firm wants to keep a record of its employees.
     * Each record would have the following characteristics
     * – first name, family name, age, gender (m or f), ID number,
     * unique employee number (27560000 to 27569999).
     * Declare the variables needed to keep the information
     * for a single employee using appropriate data types
     * and descriptive names.
    */

    string firstName;
    string familyName;
    sbyte age;
    char gender;
    int idNumber;
    int employeeNumber;

    #endregion

    #region 4
    /* 
     write an expression that checks if a given integer is odd or even  */
       void IsEven(int x)
    {
        if (x % 2 == 0)
            Console.WriteLine(x + "is an even number");
        else
            Console.WriteLine(x + "is an odd number");
       
    }

    #endregion

    #region 5

    /*
     Write a boolean expression that checks for a given integer if it can be divided (without
remainder) by 7 and 5 at the same time.
     
     */

    bool CanBeDivided(int x)
    {
        if ((x % 7) == 0 && (x % 5) == 0 && x / 7 >= 1 && x / 5 >= 1)

            return true;
        else
            return false;
    }
    #endregion

    #region 6
   /* Write an expression that calculates a rectangle's area by given width and height. */

    float Area(float length, float breadth)
    {
        return length * breadth;
    }
    #endregion

    #region 7
    /*
     A company has a name, address, phone number, fax number, web site and manager. The
manager has a first name, last name, age and a phone number. Write a program that reads the
information about a company and its manager and prints them on the console.
     */

    Console.WriteLine("what's the company's name?");
    string companysName = Console.ReadLine();

    Console.WriteLine("what's the company's address?");
    string companysaddress = Console.ReadLine();

    Console.WriteLine("what's the company's phone number?");
    string companysPhoneNumber = Console.ReadLine();

    Console.WriteLine("what's the company's fax number?");
    string companysfaxnumber = Console.ReadLine();

    Console.WriteLine("what's the company's website?");
    string companyswebsite = Console.ReadLine();

    Console.WriteLine("what's the company's manager first name, last name, age and a phone number(in that order)?");
    string companysManagerInfo = Console.ReadLine();

    void PrintCompanyDetails(string x)
    {
        Console.WriteLine(x);
    }


    Console.WriteLine(" \n Your company's details is as follows \n");
    PrintCompanyDetails(companysName);
    PrintCompanyDetails(companysaddress);
    PrintCompanyDetails(companysPhoneNumber);
    PrintCompanyDetails(companysfaxnumber);
    PrintCompanyDetails(companyswebsite);
    PrintCompanyDetails(companysManagerInfo);

    Console.Read();



    #endregion

    #region 8
    class NumberToWords
{
    private static String[] units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
    private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    public static String ConvertAmount(double amount)
    {
        try
        {
            Int64 amount_int = (Int64)amount;
            Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
            if (amount_dec == 0)
            {
                return Convert(amount_int) + " Only.";
            }
            else
            {
                return Convert(amount_int) + " Point " + Convert(amount_dec) + " Only.";
            }
        }
        catch (Exception e)
        {
            // TODO: handle exception  
        }
        return "";
    }

    public static String Convert(Int64 i)
    {
        if (i < 20)
        {
            return units[i];
        }
        if (i < 100)
        {
            return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
        }
        if (i < 1000)
        {
            return units[i / 100] + " Hundred"
                    + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");
        }
        if (i < 100000)
        {
            return Convert(i / 1000) + " Thousand "
                    + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");
        }
        if (i < 10000000)
        {
            return Convert(i / 100000) + " Lakh "
                    + ((i % 100000 > 0) ? " " + Convert(i % 100000) : "");
        }
        if (i < 1000000000)
        {
            return Convert(i / 10000000) + " Crore "
                    + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : "");
        }
        return Convert(i / 1000000000) + " Arab "
                + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");
    }


    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a Number to convert to words");
            string number = Console.ReadLine();
            number = ConvertAmount(double.Parse(number));

            Console.WriteLine("Number in words is \n{0}", number);
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    #endregion

    #region 9

    /*   
     Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
The cards should be printed with their English names. Use nested for loops and switch-case.
      */
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 5; j < 7; j--)
                {
                    if (i < 11)
                    {
                        Console.Write("{0}{1} ", i, (char)j);
                    }
                    switch (i)
                    {
                        case 11:
                            Console.Write("J{0} ", (char)j);
                            break;
                        case 12:
                            Console.Write("Q{0} ", (char)j);
                            break;
                        case 13:
                            Console.Write("K{0} ", (char)j);
                            break;
                        case 14:
                            Console.Write("A{0} ", (char)j);
                            break;
                    }
                    if (j == 3)
                    {
                        j = 7;
                    }
                    if (j == 6)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }

    #endregion




}


