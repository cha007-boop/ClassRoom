ClassRoom classRoom = new ClassRoom();

Student s1 = new Student("Christian", 4, 22);
Student s2 = new Student("Alexander", 7, 7);
Student s3 = new Student("Nikolaj", 5, 5);
Student s4 = new Student("Necati", 8, 8);

classRoom.Name = "Q3";
classRoom.SemesterStart = new DateTime(2019, 8, 26);
classRoom.Students = new List<Student> { s1, s2, s3, s4};

Console.WriteLine(classRoom);
Console.WriteLine();

Console.WriteLine($"Season count for class {classRoom.Name} student birthdays");
Helper.PrintSeasonCountForMonths(classRoom.Students.Select(s => s.BirthMonth));
