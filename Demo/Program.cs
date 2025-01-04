
namespace Demo
{
    class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
    }
    enum Gender
    {
        Male, Female
    }
    enum Grade
    {
        A, B, C, D, E, F  // Labels
    }
    enum Branch : byte
    {
        Dokki, Maadi, NasrCity, Alex, BNS, Smartvillage
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ENum
            #region Ex 01
            /// Person person = new Person();
            /// 
            /// person.Id = 1001;
            /// person.Name = "Mazen";
            /// person.Salary = 10_000;
            /// person.Gender = Gender.Male;
            /// 
            /// Gender mygender = Gender.Female;
            /// Console.WriteLine(mygender);


            /* Grade myGrade = Grade.A;*/ // 4 Bytes
            /// if(myGrade == Grade.A)
            ///     Console.WriteLine(":)");
            /// else
            ///     Console.WriteLine(":(");


            ///  myGrade = (Grade) 3;
            ///  myGrade = (Grade) 255;
            ///  Console.WriteLine(myGrade);
            #endregion

            #region Ex 02

            //Gender myGender;
            //myGender = /*UnBoxing*/ (Gender)Enum.Parse(typeof(Gender), "male", true);
            //myGender = Enum.Parse<Gender>("male",true);


            //Enum.TryParse(typeof(Gender), "Male", out object? result);
            //myGender =(Gender) (result ?? Gender.Male);

            //Enum.TryParse<Gender>("Male", true, out myGender);
            //Console.WriteLine(myGender);
            #endregion

            #endregion

        }
    }
}
