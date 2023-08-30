// collection
// array, list, dictonary
int age1;// simple, not expensive
int age2;
int age3;// age1,age2,age3, variables,objects,instances

student stu1;//0 complex
stu1 = new student();
stu1.name = "Abigail pidgeon";
stu1.age = 21;
stu1.weight = 150;
student stu2;
student stu3;

// collections 
// array
int[] agearr;// int[] is the datatype. an array. an integer array.complex. expensive.
agearr = new int[10];// created 10 integer variables.
agearr[0] = 20;//index
Console.WriteLine(agearr[0]);

//
student[] stuarr;// datatype is student[], array, student array,complex,expensive
stuarr = new student[10];//we have ten student variables, ten cards, no student created 
stuarr[0]= new student();
stuarr[0].name = "Abigail Pidgeon";
stuarr[0].age = 21;
stuarr[0].weight = 150;

Console.WriteLine(stuarr[0].name);
Console.WriteLine(stuarr[1].name);

class student//student is the data type name, complex
{
    public string name;
    public int age;
    public double weight;
}
