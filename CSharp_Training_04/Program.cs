
#define XXX
#define DEBUG
#define VERSION1
using System.Reflection;

/*
struct Book
{
    public int Id;
    public string Author;
    public string Title;
}

struct Cars
{
    private string brand;
    private string model;
    private int capacity;

    public void GetValues(string br, string mo, int ca)
    {
        brand = br;
        model = mo;
        capacity = ca;
    }
    public void WriteValues()
    {
        Console.WriteLine("Brand: " + brand + "\nModel: " + model + "\nCapacity:" + capacity + "\n");
    }
}
*/

/*
private string[] nameList = new string[size];

static int size = 10;
*/

namespace CSharp_Training_04
{
    class Program
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread started");
                for(int i=0; i<10; i++)
                {
                    Thread.Sleep(250);
                    Console.WriteLine(i);
                }
                Console.WriteLine("Child thread ended");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("CallToChildThread: THreadAbortException");
            }
            finally
            {
                Console.WriteLine("Cannot catch exception");
            }
        }

        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(CallToChildThread);
            Console.WriteLine("Main thread: creating child thread");
            Thread childThread = new Thread(ts);

            childThread.Start();

            Thread.Sleep(1500);
            
            Console.WriteLine("Main thread: child thread interrupted");
            childThread.Abort();

            Console.ReadLine();
        }
    }
}
        /*
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread started");

            int sleepFor = 5000;
            Console.WriteLine("Thread will be stopped for " + sleepFor / 1000 + " seconds");
            Thread.Sleep(sleepFor);
            Console.WriteLine("Thread resumed");
        }

        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(CallToChildThread);
            Console.WriteLine("Main thread: creating child thread");
            Thread childThread = new Thread(ts);

            childThread.Start();

            Console.ReadLine();
        }
    }
}
        */
        /*
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread has started");
        }

        static void Main(string[] args)
        {
            /*
            Thread th = Thread.CurrentThread;
            th.Name = "Thread1";
            Console.WriteLine("Thread name:" + th.Name);
            */
        /*
            ThreadStart ts = new ThreadStart(CallToChildThread);
            Console.WriteLine("Main thread: creating child thread");
            Thread childThread = new Thread(ts);

            childThread.Start();

            Console.ReadLine();
        }
    }
}
        */
        /*
        public unsafe void Swap(int* a, int* b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }

        unsafe static void Main(string[] args)
        {
            Program prog = new Program();
            int a = 30;
            int b = 55;
            int* ap = &a;
            int* bp = &b;
            Console.WriteLine("Before swap: a = {0}, b = {1}", a, b);
            prog.Swap(ap, bp);
            Console.WriteLine("After swap: a = {0}, b = {1}", a, b);

            int[] arr = { 62, 8, -40 };

            fixed (int* ptr = arr)

                for (int i=0; i<arr.Length; i++)
                {
                    Console.WriteLine("arr address[{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("arr value[{0}] = {1}", i, *(ptr + i));
                    Console.WriteLine("arr value - different method: {0}", (ptr + i)->ToString());
                }

            Console.ReadKey();
        }
    }
}*/
        /*
        unsafe static void Main(string[] args)
        {
            int* ip;
            //double* dp;
            //float* fp;
            //char* chp;
            int number = 20;

            ip = &number;
            Console.WriteLine("number value: {0}", number);
            Console.WriteLine("number value from pointer:" + ip->ToString());
            Console.WriteLine("number memory address {0}", (int)ip);
            Console.ReadLine();
        }
    }
}
*/

    /*
    delegate void ChangeNumber(int n);
    class Program
    {
        static int number = 10;
        public static void AddNumber(int a)
        {
            number += a;
            Console.WriteLine("AddNumber: number=" + number);
        }
        public static void MultiplyNumber(int m)
        {
            number *= m;
            Console.WriteLine("MultiplyNumber: number=" + number);
        }
        public static int GetNumber()
        {
            return number;
        }

        static void Main(string[] args)
        {
            ChangeNumber cn = delegate (int x)
            {
                Console.WriteLine("Anonymous method: {0}", x);
            };
            cn(8);
            cn = new ChangeNumber(AddNumber);
            cn(8);
            cn = new ChangeNumber(MultiplyNumber);
            cn(2);
            Console.WriteLine("Result: " + Program.GetNumber());
            Console.ReadLine();
        }
    }
}
    */

        /*
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            
            for (int i = 0; i < 5; i++)
                intArray.setGenericValue(i, i * 3);

            for (int i = 0; i < 5; i++)
                Console.WriteLine("i=" + i + ",genericArray[i]=" + intArray.getGenericItem(i));

            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            for (int i = 0; i < 5; i++)
                charArray.setGenericValue(i, (char)(i + 97));

            for (int i = 0; i < 5; i++)
                Console.WriteLine("i=" + i + ",genericArray[i]=" + charArray.getGenericItem(i));

            Console.ReadLine();
        }
    }
}
        */

        /*
        static void DisplayInformation(string info)
        {
            Console.WriteLine(info);
        }
        static void Main(string[] args)
        {
            DelegateOnBoardComputerEvent carComputerEvent = new DelegateOnBoardComputerEvent();

            carComputerEvent.CarComputerEventLog += new DelegateOnBoardComputerEvent.CarComputerHandler(DisplayInformation);
            carComputerEvent.LogProcess();

            Console.ReadLine();
        }
    }
}
        */

            /*
            EventTesting evt = new EventTesting(9);
            evt.SetValue(3);
            evt.SetValue(11);

            Console.ReadKey();
        }
    }
}
            */
        /*
        static FileStream fs;
        static StreamWriter sw;

        public delegate void PrintMessage(string s);
        public static void WriteToConsole(string s)
        {
            Console.WriteLine("Message: {0}", s);
        }
        public static void WriteToFile(string s)
        {
            fs = new FileStream("C:\\temp\\file1.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine(s);

            sw.Flush();

            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintMessage pm)
        {
            pm("Hello World!");
        }
        static void Main(String[] args)
        {
            PrintMessage pm1 = new PrintMessage(WriteToConsole);
            PrintMessage pm2 = new PrintMessage(WriteToFile);
            SendString(pm1);
            SendString(pm2);

            Console.ReadLine();
        }
    }
}
*/
    /*
    delegate int ChangeNumber(int i);
    public class Program
    {
        static int number = 5;
        public static int AddNumber(int i)
        {
            number += i;
            return number;
        }
        public static int MultiplyNumber(int i)
        {
            number += i;
            return number;
        }
        public static int GetNumber()
        {
            return number;
        }

        static void Main(string[] args)
        {
            ChangeNumber cn;
            ChangeNumber cn1 = new ChangeNumber(AddNumber);
            ChangeNumber cn2 = new ChangeNumber(MultiplyNumber);    

            cn1(5);
            Console.WriteLine("number=" + GetNumber());
            cn2(10);
            Console.WriteLine("number=" + GetNumber());

            cn = cn1;
            cn += cn2;
            cn(8);
            Console.WriteLine("number=" + GetNumber());

            Console.ReadLine();

            Car car = new Car();

            car.Brand = "Audi";
            car.Model = "RS6";
            car.Capacity = 4.0;
            Console.WriteLine("Info: {0}", car.ToString());

            SuperCar2 sc = new SuperCar2();
            sc.Brand = "Ferrari";
            sc.Model = "360 Modena";
            sc.Capacity = 7.5;
            Console.WriteLine("Info: " + sc.ToString());
        }
    }
}
*/
            /*
            var dog = Activator.CreateInstance(typeof(Dog)) as Dog;

            PropertyInfo[] properties = dog.GetType().GetProperties();
            PropertyInfo prep1 = properties[0];
            PropertyInfo prep2 = properties[1];

            prep1.SetValue(dog, 3);
            prep2.SetValue(dog, "dalmatian");

            Console.WriteLine(prep1.GetValue(dog, null));
            Console.WriteLine(prep2.GetValue(dog, null));

            var defaultConstr = typeof(Dog).GetConstructor(new Type[0]);
            var paramConstr = typeof(Dog).GetConstructor(new[] { typeof(int) });

            var defConstrTest = (Dog)defaultConstr.Invoke(null);
            var secConstrTest = (Dog)paramConstr.Invoke(new object[] { 3774 });

            Console.WriteLine("Constructor 1: number of legs: " + defConstrTest.NumberOfLegs);
            Console.WriteLine("Constructor 2: number of legs: " + secConstrTest.NumberOfLegs);

            var TestMethod = typeof(Dog).GetMethod("SetDogsBreed");
            var InvokeMethod = (Dog)TestMethod.Invoke(dog, new object[] { "Mixed race" });

            Console.ReadLine();
        }
    }
}
*/
            /*
            Rectangle2 r = new Rectangle2(2.5, 3.5);
            Type type = typeof(Rectangle2);

            Console.WriteLine("Class attributes:");

            foreach (Object item in type.GetCustomAttributes(false))
            {
                DebugInfo di = item as DebugInfo;
                if (di != null)
                {
                    Console.WriteLine("error number: " + di.CodeNumber);
                    Console.WriteLine("Developer: " + di.DeveloperName);
                    Console.WriteLine("Code review data: " + di.LastReviewData);
                    Console.WriteLine("Info: " + di.message);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Method attributes:");

            foreach (MethodInfo method in type.GetMethods())
            {
                foreach (Attribute a in method.GetCustomAttributes(true))
                {
                    DebugInfo di = a as DebugInfo;
                    if (di != null)
                    {
                        Console.WriteLine("error number: " + di.CodeNumber);
                        Console.WriteLine("Developer: " + di.DeveloperName);
                        Console.WriteLine("Code review data: " + di.LastReviewData);
                        Console.WriteLine("Info: " + di.message);
                    }
                }
            }

            Console.ReadKey();
        }
    }
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Property,
        AllowMultiple = true)]

    public class DebugInfo : Attribute
    {
        private int codeNumber;
        private string developerName;
        private string lastReviewData;
        public string? message;
        public DebugInfo(int code, string dev, string d)
        {
            this.codeNumber = code;
            this.developerName = dev;
            this.lastReviewData = d;
        }
        public int CodeNumber
        {
            get
            {
                return codeNumber;
            }
        }
        public string DeveloperName
        {
            get
            {
                return developerName;
            }
        }
        public string LastReviewData
        {
            get
            {
                return lastReviewData;
            }
        }
    }

    [DebugInfo(473, "Jan Kowalski", "10/11/2024", message = "Unassigned value")]
    //[DebugInfo(5601, "Jan Kowalski", "08/11/2024", message = "Wrong returned type")]
    class Rectangle2
    {
        protected double length;
        protected double width;
        public Rectangle2(double l, double w)
        {
            length = l;
            width = w;
        }
        [DebugInfo(1, "Anna Nowak", "05/04/2022", message = "Wrong returned type")]
        public double getArea()
        {
            return length * width;
        }
    }
}
*/

/*
static void Main(string[] args)
{
    System.Reflection.MemberInfo info = typeof(MyClassToGetAttributeInfo);

    object[] attributes = info.GetCustomAttributes(true);
    for (int i = 0; i < attributes.Length; i++)
    {
        Console.WriteLine(attributes[i]);
        ExampleAttribute ea = (ExampleAttribute)attributes[i];
        Console.WriteLine("Info: {0}", ea.message);
    }

    Console.ReadLine();
}
}
[AttributeUsage(AttributeTargets.All)]
public class ExampleAttribute : Attribute
{
public readonly string message;
private string topic;
public ExampleAttribute(string Message)
{
    this.message = Message;
}
public string Topic
{
    get
    {
        return topic;
    }
    set
    {
        topic = value;
    }
}
}

[ExampleAttribute("Information about my class")]
class MyClassToGetAttributeInfo
{

}
}
*/

/*
static void Main(string[] args)
{
    DisplayMessage.Message("Inside the 'Main' method");
    method1();

    Console.ReadLine();
}
[Obsolete("This method should not be used anymore. New version: newMethod()",true)]
static void oldMethod()
{
    Console.WriteLine("You are running old version of this method");
}
static void newMethod()
{
    Console.WriteLine("You are running new version of this method");
}

static void method1()
{
    DisplayMessage.Message("Inside method1");
    method2();
}
static void method2()
{
    DisplayMessage.Message("Inside method2");
}

}
class DisplayMessage
{
[Conditional("DEBUG")]
public static void Message(string message)
{
    Console.WriteLine(message);
}
*/

/*
[AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Property,
    AllowMultiple = true)]
class HelpAttribute : Attribute
{
    protected string description;
    public HelpAttribute(string Description)
    {
        this.description = Description;
    }
}
[Help("This class does nothing")]
class Class1
{
    public Class1()
    {
    }
*/
/* Incorrect declaration - the 'Help' attribute cannot be used here due to lack of
   AttributeTargets.Method property in the AttributeUsage declaration
*/
/*
[Help("This method does nothing")]
public void Method1()
{

}
}
}
*/

/*
Console.WriteLine("Sizeof(int)=" + sizeof(int));

Rectangle rect = new Rectangle(15, 20);
rect.DisplayRectangleData();

//Console.ReadKey();

// conversion
int a = 0;
byte b = 100;
a = b;
Console.WriteLine(30 + 5.0);

double d = 23.45678;
int c = (int)d;
Console.WriteLine("c=" + c);
*/
/*
short e;
int f;
double g;
e = 100;
f = 200;
g = e + f;

Console.WriteLine("e = {0}, f = {1}, g = {2}",e,f,g);
Console.ReadLine();

string s1 = "Hello world!";
string s2 = "Hello     \r world \r";
string s3 = "Hello \t \v world";
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.ReadLine();
*/

/*
const double pi = 3.14159;
double r;
Console.WriteLine("Enter radius:");
//r = Convert.ToInt32(Console.ReadLine());
r = Convert.ToDouble(Console.ReadLine());
double ar = pi * Math.Pow(r, 2);
Console.WriteLine("radius=" + r + ",area=" + ar);

int a = 27;
if (a > 27) Console.WriteLine("AAA");
else if (a > 25) Console.WriteLine("BBB");
else Console.WriteLine("CCC");

switch (a)
{
    case 15:
        Console.WriteLine("Q");
        break;
    case 21:
        Console.WriteLine("XX");
        break;
    case 23:
        Console.WriteLine("YYYYYY");
        break;
    default:
        Console.WriteLine("qqq12");
        break;
}

//object type = "John Smith";
object type = false;
switch (type.GetType().Name)
{
    case "Int32":
        Console.WriteLine("This is an Int32");
        break;
    case "String":
        Console.WriteLine("This is a string");
        break;
    case "Boolean":
        Console.WriteLine("This is a boolean");
        break;
    default:
        Console.WriteLine("This is some other type");
        break;
}

int x = 8;
int y = 26;

switch (x)
{
    case 8:
        switch (y)
        {
            case 23:
                Console.WriteLine("aaa");
                break;
            case 26:
                Console.WriteLine("bbb");
                break;
            default:
                Console.WriteLine("zzz");
                break;
        }
        break;
    case 10:
        switch (x+y)
        {
            case 15:
                Console.WriteLine("A");
                break;
            case 34:
                Console.WriteLine("aaa");
                Console.WriteLine("XXXx");
                break;
            default:
                Console.WriteLine("AA");
                break;

        }
        break;
    default:
        Console.WriteLine("bbb");
        break;
}
*/
/*
int a = 0;
while (a < 10)
{
    Console.WriteLine("a={0}", a++);
}

for (int i=0; i<3; i++)
{
    Console.WriteLine("Qqqqqq");
}

do
{
    a--;
    Console.WriteLine("a={0}", a);
} while (a > 6);

for (int i=0; i<20; i++)
{
    Console.WriteLine("i=" + i);
    if (i == 13)
        break;
}

for (int j = 0; j < 20; j++)
{
    Console.WriteLine("j=" + j);
    if (j%3 != 0)
        continue;
    Console.WriteLine("Aaaaa j=" + j);
}
*/

/*
ChooseHigherNumber hn = new ChooseHigherNumber();
int result = hn.max2(50, 18);
Console.WriteLine("Higher number is:" + result);

NumberOperations no = new NumberOperations();
int a = 6;
int b = 3;

no.exchange1(a, b);
Console.WriteLine("a={0}, b={1}", a, b);

a = 6;
b = 3;

no.exchange2(ref a, ref b);
Console.WriteLine("a={0}, b={1}", a, b);

int c;
no.getNumberOut(out c);
Console.WriteLine("c=" + c);

int d, e;
no.getTwoNumbersOut(out d, out e);
Console.WriteLine("d=" + d + ",e=" + e);
Console.ReadKey();
*/

/*
int? num1 = null;
int? num2 = 45;
double? num3 = new double?();
double? num4 = 3.14157;
bool? boolValue = new bool?();

Console.WriteLine("num1 = " + num1 + ",num2 = " + num2 + ",num3 = " + num3
    + ",num4 = " + num4 + ",boolValue = " + boolValue);

double? l1 = null;
double? l2 = 0.001;
double l3;
l3 = l1 ?? 2.58;
Console.WriteLine("l3=" + l3);
l3 = l2 ?? l3;
Console.WriteLine("l3=" + l3);
Console.ReadLine();
*/

/*
int[] tab = new int[10];
int i;

for (i = 0; i < 10; i++)
    tab[i] = i * 3 + 100;

i = 0;
foreach(int element in tab)
    Console.WriteLine("tab[" + i + "]=" + tab[i++]);

Console.ReadLine();

int[,] arr = new int[3, 4]
{
    {-33,0,-33,7},
    {1,-1,50,-33},
    {999,-133,0,-265}
};

for (int j=0; j<3; j++)
{
    for (int k=0; k<4; k++)
    {
        Console.WriteLine("arr[{0},{1}] = {2}", j, k, arr[j, k]);
    }
}

int[][][] arr1 = new int[][][]
{
    new int[][]
    {
        new int[] {5,6,7 },
        new int[] {-3, 5 }
    },
    new int[][]
    {
        new int[] {1,7,15,7,-1,333,0},
        new int[] {0},
        new int[] {44,22,4,0}
    },
    new int[][]
    {
        new int[] {75 },
        new int[] {75 },
        new int[] {-1, 0, 1},
        new int[] {333,333,75,6}
    }
};

for (int x=0; x<arr1.Length; x++)
{
    for (int y=0; y < arr1[x].Length; y++)
    {
        for (int z=0; z < arr1[x][y].Length; z++)
        {
            Console.WriteLine("arr1[" + x + "][" + y + "][" + z + "] = " + arr1[x][y][z]);
        }
    }
}
*/

/*
ArrayOperations ao = new ArrayOperations();

int sum = ao.parametricSum(22, 10, -3, -49, 27, 10);
Console.WriteLine("sum={0}",sum);

int[] arr2 = new int[] { 23, 45, 43, 12, 34, 76, 192, -232 };
int[] tempArr = arr2;

Console.WriteLine("arr2:");
foreach (int x in arr2)
    Console.Write(x + " ");
Console.WriteLine();

Array.Reverse(tempArr);

Console.WriteLine("arr2:");
foreach (int x in arr2)
    Console.Write(x + " ");
Console.WriteLine();

Array.Sort(arr2);

Console.WriteLine("arr2:");
foreach (int x in arr2)
    Console.Write(x + " ");
Console.WriteLine();

Console.ReadLine();
*/

/*
string brand, model;
brand = "Fiat";
model = "Punto";
string carName = brand + " " + model;
Console.WriteLine("carName = " + carName);

char[] chars = { 'A', 'b', 'c', 'D' };
string str = new string(chars);
Console.WriteLine("str={0}", str);

string[] arrayString = { "John", "Smith" };
string fullName = string.Join(" ", arrayString);
Console.WriteLine("fullName=" + fullName);

DateTime time = new DateTime(2001, 1, 1, 13, 59, 34);
string timeString = String.Format("timeString: time:{0:t}, day:{0:D}", time);
Console.WriteLine(timeString);

string str2 = "Qwertyuiop";
string str3 = str2.Substring(4);
string str4 = str2.Substring(2, 6);
Console.WriteLine("str3 = " + str3 + ",str4 = " + str4);

string[] strArr = { "Qwerty", "asdfg", "Werjhr", "DHuD", "638G*", "GDG*" };
string str5 = String.Join("\n", strArr);
Console.WriteLine("str5=" + str5);

Console.ReadLine();
*/

/*
Book book1;
book1.Id = 1;
book1.Author = "John Smith";
book1.Title = "Something Nice";

Book book2;
book2.Id = 2;
book2.Author = "Anna Johnson";
book2.Title = "Adventures of Captain John";

Console.WriteLine("book1.Title = " + book1.Title);

Cars cars1 = new Cars();
cars1.GetValues("Lamborghini", "Diablo", 5000);
cars1.WriteValues();

int color1 = (int)Colors.Red;
int color2 = (int)Colors.Yellow;
Console.WriteLine("color1 = {0}, color2 = {1}", color1, color2);

Console.ReadLine();
}
enum Colors
{
Red,
Green = 24,
Blue,
Yellow = 50
}
*/
/*
ConstructorDestructor cd = new ConstructorDestructor(1);
cd.getNumber();
cd.setNumber(423);
cd.getNumber();

StaticComponents sc1 = new StaticComponents();
StaticComponents sc2 = new StaticComponents();

sc1.zeroX();
sc2.zeroX();
sc1.increaseX();
sc1.increaseX();
sc1.increaseX();
Console.WriteLine("sc1.x=" + sc1.getX() + ",sc2.x=" + sc2.getX());
sc2.increaseX();
Console.WriteLine("sc1.x=" + sc1.getX() + ",sc2.x=" + sc2.getX());
sc2.zeroX();
sc1.increaseX();
Console.WriteLine("sc1.x=" + sc1.getX() + ",sc2.x=" + sc2.getX());

Console.WriteLine(StaticClass.Add(3, 4));
Console.WriteLine(StaticClass.Subtract(3, 4));
*/
/*
Tabletop tabletop = new Tabletop(13.5, 17.0);
tabletop.getTableData();

double vol = 0;
Box b1 = new Box();
Box b2 = new Box();
Box b3 = new Box();

b1.setLength(2.3);
b1.setWidth(4.9);
b1.setHeight(0.82);
b2.setLength(2.65);
b2.setWidth(7.1);
b2.setHeight(4);
b3.setLength(4);
b3.setWidth(1.5);
b3.setHeight(2.75);

vol = b1.getVolume();
Console.WriteLine("b1.volume=" + vol);
vol = b2.getVolume();
Console.WriteLine("b2.volume=" + vol);
vol = b3.getVolume();
Console.WriteLine("b3.volume=" + vol);

b3 = b1 + b2; // adding two 'Box' objects using opertor defined inside the 'Box' class

vol = b3.getVolume();
Console.WriteLine("b3.volume=" + vol);

if (b1 == b2) Console.WriteLine("b1 and b2 boxes are equal");
if (b1 != b2) Console.WriteLine("b1 and b2 boxes are different");
*/

/*
Square sq = new Square(3);
double ar = sq.Area();
Console.WriteLine("Area of sq = {0}", ar);

Transactions t1 = new Transactions("A307C", 5);
Transactions t2 = new Transactions("CG*8", 2);

t1.DisplayData();
t2.DisplayData();
*/

/*
ns1 n1 = new ns1();
ns2 n2 = new ns2();
ns1a n1a = new ns1a();

n1.someMethod();
n2.someMethod();
n1a.someMethod();
*/
/*
#if (XXX)
Console.WriteLine("XXX is defined");
#else
Console.WriteLine("XXX is not defined");
#endif

#if (DEBUG && VERSION1)
Console.WriteLine("DEBUG and VERSION1 are defined");
#elif (DEBUG && !VERSION1)
Console.WriteLine("DEBUG is defined, but VERSION1 is not");
#else
Console.WriteLine("DEBUG is not defined");
#endif
*/
/*
string str1 = "This is Mr. John Smith";

RegexOperations.testMatching(str1, "[A-Z][a-z]");
Regex reg1 = new Regex("i[a-z]");
string str2 = reg1.Replace(str1, "Abrakadabra123");

Console.WriteLine("str2 = " + str2);

Exceptions exc = new Exceptions();
exc.DivideByZero(7);

Age a = new Age();
try
{
    a.checkAge(-1);
}
catch(Exception ex)
{
    Console.WriteLine("Exception raised: {0}", ex.Message);
}

try
{
    a.checkAge2(-5);
}
catch(MyOwnException ex)
{
    Console.WriteLine("Exception raised: {0}", ex.Message);
}
*/

/*
FileStream fs = new FileStream("file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

for (int i = 0; i < 10; i++)
    fs.WriteByte((byte)i);

fs.Position = 0;
for (int i = 0; i < 10; i++)
    Console.Write(fs.ReadByte() + " ");
fs.Close();
*/

/*
ArrayList list1 = new ArrayList();
list1.Add(50);
list1.Add(32);
list1.Add(50);

Console.WriteLine("list1.Count = {0}, list1.Capacity = {1}", list1.Count, list1.Capacity);

list1.Add(0);
list1.Add(-3);
list1.Add(555);
list1.Add(0);

Console.WriteLine("list1.Count = {0}, list1.Capacity = {1}", list1.Count, list1.Capacity);

Console.WriteLine("The whole list1:");
foreach (var el in list1)
    Console.Write(el + " ");

list1.RemoveAt(2);

Console.WriteLine("The whole list1:");
foreach (var el in list1)
    Console.Write(el + " ");

Hashtable ht1 = new Hashtable();

ht1.Add("186", "Adam");
ht1.Add("1023", "Robert");
ht1.Add("222", "Madelaine");
ht1.Add("1093", "Catherine");
ht1.Add("6787", "Thomas");

if (!ht1.ContainsKey("0004"))
    ht1.Add("0004", "Paul");

ICollection ic1 = ht1.Keys;
foreach (var k in ic1)
{
    Console.Write(k + " " + ht1[k]);
    Console.WriteLine();
}

ht1.Clear();
Console.WriteLine("ht1.Count = {0}", ht1.Count);

SortedList sl1 = new SortedList();

sl1.Add(12, "Aaa");
sl1.Add(9, "Fhfgh");
sl1.Add(3, "436 w8y");
sl1.Add(10, "X");

if (sl1.ContainsKey(9))
    Console.WriteLine("Value of sl1[9] = " + sl1[9]);
else
    sl1.Add(9, "sidsdias");

if (sl1.ContainsValue("Aaa"))
    Console.WriteLine("Aaa already exists in list");
else
    sl1.Add(1, "Aaa");

*/

/*
Stack st1 = new Stack();

st1.Push(2);
st1.Push(3);
st1.Push(2);

foreach (var el in st1)
{
    Console.WriteLine(el);
}
int x;
x = (int)st1.Pop();
Console.WriteLine("Popped element: {0}", x);

foreach (var el in st1)
{
    Console.WriteLine(el);
}

Console.WriteLine("Value of element at top of the stack: " + st1.Peek());

Queue q = new Queue();
q.Enqueue("A");
q.Enqueue("B");
q.Enqueue("C");
q.Enqueue("D");
q.Enqueue("E");

q.Dequeue();

foreach(var el in q)
{
    Console.WriteLine(el);
}

BitArray ba1 = new BitArray(8);
BitArray ba2 = new BitArray(8);
byte[] a = { 54 };
byte[] b = { 255 };
ba1 = new BitArray(a);
ba2 = new BitArray(b);

for (int i = 0; i < ba1.Count; i++)
{
    Console.Write("{0, -6}", ba1[i]); // align text left-side to 6 characters
}
for (int i = 0; i < ba2.Count; i++)
{
    Console.Write("{0, 6}", ba2[i]); // align text right-side to 6 characters
}
*/

/*
Program names = new Program();
names[0] = "Marcin";
names[1] = "Anna";
names[2] = "Krzysztof";
names[3] = "Agnieszka";

for (int i = 0; i < size; i++)
    Console.WriteLine(names[i]);

Console.WriteLine(names["Anna"]);
*/

/*
HashSet<string> set1 = new HashSet<string>();

set1.Add("A");
set1.Add("qqq qqq");
set1.Add("123");
set1.Add("    ");
set1.Add("PPPP p");

set1.Remove("A");

foreach (string s in set1)
{
    Console.WriteLine(s);
}

HashSet<string> set2 = new HashSet<string>();

set2.Add("A");
set2.Add("B");
set2.Add("123");

set1.UnionWith(set2);

foreach (string s in set2)
{
    Console.WriteLine(s);
}

HashSet<string> set3 = new HashSet<string>();

set3.Add("B");
set3.Add("XXXX");
set3.Add("    ");
set3.Add("kx ");
set3.Add("1117");

set3.IntersectWith(set2);

foreach (string s in set3)
{
    Console.WriteLine(s);
}

HashSet<string> set4 = new HashSet<string>();
set4.Add("XYZ");
set4.Add("A");
set4.Add(" eee 111");
set4.Add("123");

set4.ExceptWith(set2);

foreach (string s in set4)
{
    Console.WriteLine(s);
}


Console.ReadLine();

}
*/

// Indexer

/*
public string this[int index]
{
    get
    {
        if (index >= 0 && index <= size - 1)
            return nameList[index];
        else
            return "";
    }
    set
    {
        if (index >= 0 && index <= size - 1)
            nameList[index] = value;
    }
}
*/
// Indexers can be overloaded
/*
public int this[string name]
{
    get
    {
        int index = 0;
        while (index < size)
        {
            if (nameList[index] == name)
                return index;
            index++;
        }
        return index;
    }
    set
    {

    }
}
}
}
*/
