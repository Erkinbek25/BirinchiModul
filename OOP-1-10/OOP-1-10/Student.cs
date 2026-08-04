namespace OOP_1_10;

public class Student
{

    public Student()
    {

    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    //public string Grade { get; set; }
    public int BirthYear { get; set; }
    public string Addess { get; set; }
    public string PhoneNumber { get; set; }

    private int age;   // (1)
    private string grade;

    public string Grade
    {
        get { return grade; }
        set
        {
            if (value != "A" && value != "B" && value != "D" && value != "C" && value != "F")
            {
                Console.WriteLine("Xato kritilgan iltimos tekshirib qayta kriting");
            }
            else
            {
                grade = value;
            }
        }
    }
    public int Age      // (2)
    {
        get { return age; }   // (3)
        set                    // (4)
        {
            if (value < 0 || value > 100)   // (5)
            {
                Console.WriteLine("Xato: yosh 0 dan 100 gacha bo'lishi kerak!");
            }
            else
            {
                age = value;   // (6)
            }
        }
    }

    public void BahoOshir()
    {
        if (Grade == "A")
        {
            Grade = "A+";
        }
        else if (Grade == "B")
        {
            Grade = "A";
        }
        else if (Grade == "C")
        {
            Grade = "B";
        }
        else if (Grade == "D")
        {
            Grade = "C";
        }
        else
        {
            Console.WriteLine("Baho oshirib bo'lmaydi.");
        }
    }


}

