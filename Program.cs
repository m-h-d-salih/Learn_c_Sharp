// Console.WriteLine("salih");
// int n=10;
// float f=1.5f;
// long lo=1233455;
// bool bl=true;
// char c='q';
// String str="salih";
// Console.WriteLine(n+f+lo);
// Console.WriteLine(c+str+" is"+bl);
// Console.WriteLine("enter ur name");
// String? name=Console.ReadLine();
// Console.WriteLine("enter ur age");
// int age=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("your name is"+name+"your age is"+age);
void message(){
    Console.WriteLine("hello world");
}
message();
void sum(int a,int b){
    Console.WriteLine(a+b);
}
sum(12,34);
float mul(float a,int b){
    return a*b;
}
Console.WriteLine(mul(12.34f,34));

// String s=null;
// String reuslt=s??"hii";
// Console.WriteLine(reuslt);
//  s??="hii";
// Console.WriteLine(s);
Console.WriteLine("enter ur name ");
String? name=Console.ReadLine();
int age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ur name is "+name.GetType()+"ur age is "+age.GetType());
// int nameint=Convert.
String[] cars={"bugatti","ferrari"};
Console.WriteLine(cars);