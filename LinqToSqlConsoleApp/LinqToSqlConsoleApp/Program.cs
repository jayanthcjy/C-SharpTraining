using LinqToSqlConsoleApp;

DataClasses1DataContext data=new DataClasses1DataContext("DbConnection");
List<student> studentData=data.students.ToList();
student obj =new student();

for(int i = 0; i < studentData.Count; i++)
{
    Console.WriteLine(studentData[i].name.ToString());
}